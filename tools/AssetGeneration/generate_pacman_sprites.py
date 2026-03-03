#!/usr/bin/env python3
"""
Generador de Sprite Sheet de Arcade Maze Chomper - Estilo 8-bit Clásico
Genera todos los sprites necesarios para el juego Arcade Maze Chomper
"""

from PIL import Image, ImageDraw
import math

# Configuración
SPRITE_SIZE = 32  # Tamaño de cada sprite individual
SPRITE_SCALE = 2  # Factor de escala para mejor visualización

# Colores clásicos de Arcade Maze Chomper (RGB)
PACMAN_YELLOW = (255, 255, 0)
BACKGROUND = (0, 0, 0, 0)  # Transparente
BLACK = (0, 0, 0)

def create_pacman_sprite(direction='right', frame=0):
    """
    Crea un sprite de Arcade Maze Chomper
    
    Args:
        direction: 'right', 'left', 'up', 'down'
        frame: 0 (boca cerrada), 1 (semi-abierta), 2 (abierta)
    
    Returns:
        Image object
    """
    size = SPRITE_SIZE
    img = Image.new('RGBA', (size, size), BACKGROUND)
    draw = ImageDraw.Draw(img)
    
    # Centro del sprite
    center = size // 2
    radius = size // 2 - 2
    
    # Ángulos de apertura de boca según el frame
    mouth_angles = {
        0: 0,      # Cerrado (círculo completo)
        1: 20,     # Semi-abierto
        2: 45      # Completamente abierto
    }
    
    mouth_angle = mouth_angles.get(frame, 0)
    
    # Direcciones de la boca
    direction_angles = {
        'right': 0,
        'up': 90,
        'left': 180,
        'down': 270
    }
    
    base_angle = direction_angles.get(direction, 0)
    
    if mouth_angle == 0:
        # Círculo completo (boca cerrada)
        bbox = [center - radius, center - radius, 
                center + radius, center + radius]
        draw.ellipse(bbox, fill=PACMAN_YELLOW, outline=PACMAN_YELLOW)
    else:
        # Arcade Maze Chomper con boca abierta (usando chord para crear el efecto)
        bbox = [center - radius, center - radius, 
                center + radius, center + radius]
        
        # Calcular ángulos de inicio y fin
        start_angle = base_angle + mouth_angle
        end_angle = base_angle - mouth_angle + 360
        
        # Dibujar el círculo con la boca
        draw.pieslice(bbox, start=start_angle, end=end_angle, 
                      fill=PACMAN_YELLOW, outline=PACMAN_YELLOW)
    
    # Añadir un pequeño ojo (solo visible cuando la boca está cerrada o semi-abierta)
    if frame < 2:
        eye_offset_x = radius // 3
        eye_offset_y = radius // 2
        eye_size = 2
        
        # Ajustar posición del ojo según dirección
        if direction == 'right':
            eye_x = center + eye_offset_x
            eye_y = center - eye_offset_y
        elif direction == 'left':
            eye_x = center - eye_offset_x
            eye_y = center - eye_offset_y
        elif direction == 'up':
            eye_x = center + eye_offset_y
            eye_y = center - eye_offset_x
        else:  # down
            eye_x = center + eye_offset_y
            eye_y = center + eye_offset_x
        
        eye_bbox = [eye_x - eye_size, eye_y - eye_size,
                    eye_x + eye_size, eye_y + eye_size]
        draw.ellipse(eye_bbox, fill=BLACK)
    
    return img

def create_pacman_death_sprite(frame):
    """
    Crea sprites de animación de muerte de Arcade Maze Chomper
    
    Args:
        frame: 0-10 (progresión de la animación de muerte)
    
    Returns:
        Image object
    """
    size = SPRITE_SIZE
    img = Image.new('RGBA', (size, size), BACKGROUND)
    draw = ImageDraw.Draw(img)
    
    center = size // 2
    radius = size // 2 - 2
    
    if frame < 8:
        # Abrir la boca gradualmente
        mouth_angle = frame * 22.5  # 0 a 180 grados
        bbox = [center - radius, center - radius, 
                center + radius, center + radius]
        
        start_angle = 90 + mouth_angle
        end_angle = 90 - mouth_angle + 360
        
        draw.pieslice(bbox, start=start_angle, end=end_angle, 
                      fill=PACMAN_YELLOW, outline=PACMAN_YELLOW)
    else:
        # Últimos frames: punto pequeño o vacío
        small_radius = (10 - frame) * 2
        if small_radius > 0:
            bbox = [center - small_radius, center - small_radius,
                    center + small_radius, center + small_radius]
            draw.ellipse(bbox, fill=PACMAN_YELLOW)
    
    return img

def create_pacman_spritesheet():
    """
    Crea el sprite sheet completo de Arcade Maze Chomper
    
    Layout:
    Fila 1: Right (frames 0, 1, 2)
    Fila 2: Left (frames 0, 1, 2)
    Fila 3: Up (frames 0, 1, 2)
    Fila 4: Down (frames 0, 1, 2)
    Fila 5-6: Death animation (frames 0-10)
    """
    
    # Dimensiones del sprite sheet
    cols = 6  # 6 columnas
    rows = 6  # 6 filas
    
    sheet_width = SPRITE_SIZE * cols
    sheet_height = SPRITE_SIZE * rows
    
    sprite_sheet = Image.new('RGBA', (sheet_width, sheet_height), BACKGROUND)
    
    directions = ['right', 'left', 'up', 'down']
    
    # Generar sprites de movimiento (primeras 4 filas)
    for row, direction in enumerate(directions):
        for col in range(3):
            sprite = create_pacman_sprite(direction, col)
            x = col * SPRITE_SIZE
            y = row * SPRITE_SIZE
            sprite_sheet.paste(sprite, (x, y))
    
    # Generar sprites de muerte (filas 5 y 6)
    death_frames = 11
    for i in range(death_frames):
        sprite = create_pacman_death_sprite(i)
        row = 4 + (i // cols)
        col = i % cols
        x = col * SPRITE_SIZE
        y = row * SPRITE_SIZE
        sprite_sheet.paste(sprite, (x, y))
    
    return sprite_sheet

def create_sprite_map_json():
    """
    Crea un archivo JSON con las coordenadas de cada sprite
    """
    sprite_map = {
        "sprite_size": SPRITE_SIZE,
        "sprites": {
            "pacman": {
                "right": [
                    {"x": 0, "y": 0, "frame": 0},
                    {"x": 32, "y": 0, "frame": 1},
                    {"x": 64, "y": 0, "frame": 2}
                ],
                "left": [
                    {"x": 0, "y": 32, "frame": 0},
                    {"x": 32, "y": 32, "frame": 1},
                    {"x": 64, "y": 32, "frame": 2}
                ],
                "up": [
                    {"x": 0, "y": 64, "frame": 0},
                    {"x": 32, "y": 64, "frame": 1},
                    {"x": 64, "y": 64, "frame": 2}
                ],
                "down": [
                    {"x": 0, "y": 96, "frame": 0},
                    {"x": 32, "y": 96, "frame": 1},
                    {"x": 64, "y": 96, "frame": 2}
                ],
                "death": [
                    {"x": i % 6 * 32, "y": (4 + i // 6) * 32, "frame": i}
                    for i in range(11)
                ]
            }
        }
    }
    
    import json
    with open('pacman_sprite_map.json', 'w') as f:
        json.dump(sprite_map, f, indent=2)
    
    print("✅ Archivo JSON de mapeo creado: pacman_sprite_map.json")

def main():
    print("🎮 Generador de Sprites de Arcade Maze Chomper")
    print("=" * 50)
    
    # Generar sprite sheet de Arcade Maze Chomper
    print("Generando sprite sheet de Arcade Maze Chomper...")
    pacman_sheet = create_pacman_spritesheet()
    
    # Guardar sprite sheet
    output_path = 'pacman_spritesheet.png'
    pacman_sheet.save(output_path)
    print(f"✅ Sprite sheet guardado: {output_path}")
    
    # Crear mapa de sprites (JSON)
    create_sprite_map_json()
    
    # Información del sprite sheet
    print("\n📊 Información del Sprite Sheet:")
    print(f"   - Tamaño total: {pacman_sheet.width}x{pacman_sheet.height} píxeles")
    print(f"   - Tamaño de sprite individual: {SPRITE_SIZE}x{SPRITE_SIZE} píxeles")
    print(f"   - Total de sprites: 23")
    print(f"   - Distribución:")
    print(f"     • Movimiento derecha: 3 frames")
    print(f"     • Movimiento izquierda: 3 frames")
    print(f"     • Movimiento arriba: 3 frames")
    print(f"     • Movimiento abajo: 3 frames")
    print(f"     • Animación muerte: 11 frames")
    
    print("\n✨ ¡Generación completada!")
    print(f"   Archivos creados:")
    print(f"   - pacman_spritesheet.png")
    print(f"   - pacman_sprite_map.json")

if __name__ == "__main__":
    main()
