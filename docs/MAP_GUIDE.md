# 🗺️ Arcade Maze Chomper Map Guide

## 📋 Table of Contents
1. [Map Format](#map-format)
2. [Character Legend](#character-legend)
3. [Technical Specifications](#technical-specifications)
4. [Included Maps](#included-maps)
5. [How to Create Custom Maps](#how-to-create-custom-maps)
6. [Map Validation](#map-validation)

---

## 🎮 Map Format

Arcade Maze Chomper maps are stored in plain text files (.txt) where each character represents a game element.

### Standard Dimensions:
- **Width:** 28 characters (columns)
- **Height:** 31 characters (rows)
- **Total cells:** 868 cells

---

## 🔤 Character Legend

| Character | Element | Description | Behavior |
|-----------|---------|-------------|----------|
| `#` | **Wall** | Maze wall | Blocks Arcade Maze Chomper and ghost movement |
| `.` | **Small Dot** | Energizer pill | +10 points, Arcade Maze Chomper can pass through |
| `o` | **Power Pellet** | Large dot | +50 points, makes ghosts vulnerable |
| `P` | **Arcade Maze Chomper** | Player start position | Replaced by empty space at start |
| `G` | **Ghost** | Ghost start position | Replaced by empty space at start |
| `-` | **Door** | Ghost house door | Only ghosts can pass through |
| `F` | **Fruit** | Optional bonus | +100 to +1000 points depending on type |
| ` ` | **Empty Space** | Cell with no content | Free for movement |

---

## ⚙️ Technical Specifications

### Map Structure:

```
############################  ← Row 1 (top border)
#............##............#  ← Row 2 (corridor with dots)
#.####.#####.##.#####.####.#  ← Row 3 (internal walls)
...
#..........................#  ← Row 30 (bottom corridor)
############################  ← Row 31 (bottom border)
```

### Design Rules:

1. **Mandatory Borders:**
   - First row: completely `#`
   - Last row: completely `#`
   - First column: always `#`
   - Last column: always `#`

2. **Ghost House:**
   - Must be in the center of the map
   - Surrounded by walls `#`
   - One door `-` for entry/exit
   - 6 `G` positions for ghosts

3. **Arcade Maze Chomper Position:**
   - There must be only **ONE** `P` character in the entire map
   - Generally in the lower part of the maze
   - Surrounded by free space for initial movement

4. **Dot Distribution:**
   - **Small Dots (`.`):** ~240-250 in the map
   - **Power Pellets (`o`):** Exactly 4 (one in each corner)

5. **Connectivity:**
   - All corridors must be connected
   - There should be no isolated areas
   - It must be possible to reach all dots

---

## 🎯 Included Maps

### Level 1 - Classic (level1.txt)
```
Difficulty: ⭐⭐☆☆☆ (Easy)
Features:
- Classic original Arcade Maze Chomper design
- Wide corridors
- 4 power pellets in corners
- Central ghost house
- Ideal for starting

Statistics:
- Small dots: ~244
- Power pellets: 4
- Total possible points: ~2,640
```

### Level 2 - Intermediate (level2.txt)
```
Difficulty: ⭐⭐⭐☆☆ (Medium)
Features:
- More internal walls
- Narrower corridors
- Higher difficulty to escape
- Power pellets in strategic positions

Statistics:
- Small dots: ~228
- Power pellets: 4
- Total possible points: ~2,480
```

### Level 3 - Advanced (level3.txt)
```
Difficulty: ⭐⭐⭐⭐☆ (Hard)
Features:
- Complex maze
- Dead ends
- Less maneuvering space
- Requires advanced strategy

Statistics:
- Small dots: ~220
- Power pellets: 4
- Total possible points: ~2,400
```

---

## 🛠️ How to Create Custom Maps

### Step 1: Create the file
```
File: levelX.txt (where X is the level number)
Encoding: UTF-8 without BOM
Line ending: LF or CRLF (both work)
```

### Step 2: Design the outline
```
############################
#                          #
#                          #
...
#                          #
############################
```

### Step 3: Add the ghost house
```
######## ##########
######## ##########
########          ##########
######## ###--### ##########
######## #GGGGGG# ##########
         #GGGGGG#   
######## #GGGGGG# ##########
######## ######## ##########
```

**Important:** 
- 6 `G` positions (for 4 ghosts + space)
- Horizontal door `-` at the top
- Symmetry recommended

### Step 4: Design corridors and walls
```
Tips:
- Maintain symmetry (not mandatory but visually pleasing)
- Create escape routes
- Avoid long dead ends
- Leave space for strategy
```

### Step 5: Place dots
```
- Small dots (.) in all corridors
- 4 Power Pellets (o) in strategic corners
- Leave empty spaces in:
  * Ghost house
  * Around Arcade Maze Chomper's starting position
  * Side tunnels (optional)
```

### Step 6: Place Arcade Maze Chomper
```
- A single P character
- In a safe zone (far from ghosts)
- Generally in the lower part
- With maneuvering space
```

### Example of Arcade Maze Chomper Start Area:
```
#......##....##....##......#
#.##########.##.##########.#
#..........P.##............#  ← Arcade Maze Chomper here
############################
```

---

## ✅ Map Validation

### Checklist Before Using a Map:

**Dimensions:**
- [ ] Exactly 28 columns
- [ ] Exactly 31 rows
- [ ] All rows have the same length

**Mandatory Elements:**
- [ ] 1 Arcade Maze Chomper (`P`)
- [ ] 4-6 Ghosts (`G`)
- [ ] 1 Door (`-`)
- [ ] 4 Power Pellets (`o`) minimum
- [ ] ~200+ Small Dots (`.`)

**Borders:**
- [ ] Top row completely with `#`
- [ ] Bottom row completely with `#`
- [ ] Left column completely with `#`
- [ ] Right column completely with `#`

**Gameplay:**
- [ ] All corridors are connected
- [ ] No isolated areas without access
- [ ] Ghost house accessible only by door
- [ ] Arcade Maze Chomper can reach all dots

**Ghost House:**
- [ ] Center of the map (approximately)
- [ ] Enclosed by walls
- [ ] One entry/exit door
- [ ] 6 G positions inside

---

## 🎨 Empty Template for New Maps

```
############################
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
######         ##    #######
######         ##    #######
######                ######
###### ############ #######
###### #          # #######
       #          #        
###### #          # #######
###### ############ #######
######                ######
###### ############ #######
###### ############ #######
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
#                          #
############################
```

---

## 💡 Advanced Design Tips

### Progressive Difficulty:

**Easy Level:**
- Wide corridors (3-4 cells)
- Few internal walls
- Many escape routes
- Accessible power pellets

**Medium Level:**
- Medium corridors (2-3 cells)
- More internal walls
- Some narrow zones
- Strategic power pellets

**Hard Level:**
- Narrow corridors (1-2 cells)
- Complex maze
- Dead ends
- Power pellets in dangerous zones

### Classic Patterns:

**Side Tunnel (optional):**
```
#                          #
                             ← Tunnel connecting sides
#                          #
```

**Central Zone:**
```
#............##............#  ← Wide combat zone
#.####.#####.##.#####.####.#
```

**Strategic Corners:**
```
#o####.#####.##.#####.####o#  ← Power pellets in corners
```

---

## 🚀 Map Loading in C#

### Code Example:

```csharp
public class MapLoader
{
    public static char[,] LoadMap(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        int rows = lines.Length;
        int cols = lines[0].Length;
        
        char[,] map = new char[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                map[i, j] = j < lines[i].Length ? lines[i][j] : ' ';
            }
        }
        
        return map;
    }
}
```

---

## 📊 Maximum Score Calculation

```
Formula:
Maximum Score = (Small Dots × 10) + (Power Pellets × 50) + (Fruits × Bonus)

Level 1 Example:
- 244 small dots × 10 = 2,440
- 4 power pellets × 50 = 200
- Base total: 2,640 points

+ Ghosts eaten during power-up
+ Bonus fruits
= Total Possible Score
```

---

## 🎯 Best Practices

1. **Test your map:** Play several levels to verify balance
2. **Symmetry:** Helps visually but is not mandatory
3. **Variety:** Each level should feel different
4. **Progression:** Increase difficulty gradually
5. **Document:** Add comments about special features

---

## 📝 Final Notes

- Maps are loaded from `/Assets/Maps/`
- Name format: `level{number}.txt`
- You can create infinite levels
- The game can rotate between available maps
- Consider creating a simple "tutorial" map

---

## 🔗 References

- Original Arcade Maze Chomper: 28×31 cells
- Ghost House: Always central
- Power Pellets: Traditionally 4 in corners
- Classic Design: Vertically symmetric

---

**Author:** Diego Alejandro  
**Project:** Arcade Maze Chomper Educational Recreation  
**Date:** 2026  
**License:** MIT
