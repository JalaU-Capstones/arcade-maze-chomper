# 📁 Project Structure

Complete directory structure for Arcade Maze Chomper Educational Recreation

```
pacman-recreation/
│
├── .github/                              # GitHub specific files
│   └── workflows/
│       ├── build-and-test.yml           # CI/CD pipeline
│       └── release.yml                   # Release automation
│
├── src/                                  # Source code
│   └── MazeChomperGame/
│       ├── MazeChomperGame.csproj            # Project file
│       ├── Program.cs                    # Application entry point
│       ├── App.axaml                     # Application definition
│       ├── App.axaml.cs                  # Application code-behind
│       │
│       ├── Assets/                       # Game resources
│       │   ├── Sprites/
│       │   │   ├── pacman_spritesheet.png
│       │   │   ├── pacman_sprite_map.json
│       │   │   ├── ghosts_spritesheet.png
│       │   │   ├── ghosts_sprite_map.json
│       │   │   ├── items_spritesheet.png
│       │   │   ├── items_sprite_map.json
│       │   │   ├── tiles_spritesheet.png
│       │   │   └── tiles_sprite_map.json
│       │   │
│       │   ├── Audio/
│       │   │   ├── Music/
│       │   │   │   ├── background-theme.wav
│       │   │   │   ├── menu-theme.wav
│       │   │   │   └── game-over-theme.wav
│       │   │   └── SFX/
│       │   │       ├── chomp.wav
│       │   │       ├── eat-power-pellet.wav
│       │   │       ├── eat-ghost.wav
│       │   │       ├── eat-fruit.wav
│       │   │       ├── death.wav
│       │   │       ├── extra-life.wav
│       │   │       ├── game-start.wav
│       │   │       ├── level-complete.wav
│       │   │       ├── game-over.wav
│       │   │       ├── menu-select.wav
│       │   │       ├── menu-navigate.wav
│       │   │       └── ghost-return.wav
│       │   │
│       │   └── Maps/
│       │       ├── level1.txt
│       │       ├── level2.txt
│       │       └── level3.txt
│       │
│       ├── Models/                       # Data models
│       │   ├── Entities/
│       │   │   ├── Pacman.cs
│       │   │   ├── Ghost.cs
│       │   │   ├── Collectible.cs
│       │   │   ├── Tile.cs
│       │   │   └── Entity.cs            # Base entity class
│       │   │
│       │   ├── Enums/
│       │   │   ├── Direction.cs
│       │   │   ├── GhostType.cs
│       │   │   ├── GhostState.cs
│       │   │   ├── CollectibleType.cs
│       │   │   ├── TileType.cs
│       │   │   └── GameMode.cs
│       │   │
│       │   └── Game/
│       │       ├── GameState.cs
│       │       ├── Level.cs
│       │       ├── Profile.cs           # User profile
│       │       ├── ScoreEntry.cs        # High score
│       │       └── Settings.cs          # Audio settings
│       │
│       ├── ViewModels/                   # MVVM ViewModels
│       │   ├── ViewModelBase.cs         # Base for all ViewModels
│       │   ├── MainWindowViewModel.cs
│       │   ├── MainMenuViewModel.cs
│       │   ├── GameViewModel.cs
│       │   ├── ScoreBoardViewModel.cs
│       │   ├── SettingsViewModel.cs
│       │   ├── ProfileCreationViewModel.cs
│       │   └── ProfileSelectionViewModel.cs
│       │
│       ├── Views/                        # MVVM Views (AXAML)
│       │   ├── MainWindow.axaml
│       │   ├── MainWindow.axaml.cs
│       │   ├── MainMenuView.axaml
│       │   ├── MainMenuView.axaml.cs
│       │   ├── GameView.axaml
│       │   ├── GameView.axaml.cs
│       │   ├── ScoreBoardView.axaml
│       │   ├── ScoreBoardView.axaml.cs
│       │   ├── SettingsView.axaml
│       │   ├── SettingsView.axaml.cs
│       │   ├── ProfileCreationView.axaml
│       │   ├── ProfileCreationView.axaml.cs
│       │   ├── ProfileSelectionView.axaml
│       │   └── ProfileSelectionView.axaml.cs
│       │
│       ├── Services/                     # Business logic
│       │   ├── Interfaces/
│       │   │   ├── IMapLoader.cs
│       │   │   ├── ISpriteManager.cs
│       │   │   ├── IAudioManager.cs
│       │   │   ├── ICollisionDetector.cs
│       │   │   ├── IProfileManager.cs
│       │   │   └── IGameEngine.cs
│       │   │
│       │   ├── MapLoader.cs
│       │   ├── SpriteManager.cs
│       │   ├── AudioManager.cs
│       │   ├── CollisionDetector.cs
│       │   ├── ProfileManager.cs        # SQLite database management
│       │   ├── GameEngine.cs
│       │   │
│       │   └── AI/
│       │       ├── IGhostAI.cs
│       │       ├── BlinkyAI.cs          # Red - Direct chase
│       │       ├── PinkyAI.cs           # Pink - Ambush
│       │       ├── InkyAI.cs            # Cyan - Flanking
│       │       ├── ClydeAI.cs           # Orange - Random/scatter
│       │       └── PathFinder.cs        # A* or similar
│       │
│       ├── Helpers/                      # Utility classes
│       │   ├── Constants.cs
│       │   ├── Extensions.cs
│       │   └── MathHelper.cs
│       │
│       └── Styles/                       # UI Styles
│           ├── ButtonStyles.axaml
│           ├── TextStyles.axaml
│           └── Colors.axaml
│
├── tests/                                # Test projects
│   └── MazeChomperGame.Tests/
│       ├── MazeChomperGame.Tests.csproj
│       ├── Models/
│       │   └── PacmanTests.cs
│       ├── Services/
│       │   ├── MapLoaderTests.cs
│       │   ├── CollisionDetectorTests.cs
│       │   └── AI/
│       │       └── GhostAITests.cs
│       └── ViewModels/
│           └── GameViewModelTests.cs
│
├── tools/                                # Development tools
│   ├── AssetGeneration/
│   │   ├── requirements.txt              # Python dependencies
│   │   ├── generate_pacman_sprites.py
│   │   ├── generate_ghosts_sprites.py
│   │   ├── generate_items_sprites.py
│   │   ├── generate_tiles_sprites.py
│   │   ├── generate_sound_effects.py
│   │   └── generate_music.py
│   │
│   └── Scripts/
│       ├── build.sh                      # Build script (Linux/Mac)
│       ├── build.cmd                     # Build script (Windows)
│       ├── publish.sh                    # Publish script (Linux/Mac)
│       └── publish.cmd                   # Publish script (Windows)
│
├── docs/                                 # Documentation
│   ├── images/
│   │   ├── preview.png
│   │   ├── gameplay.gif
│   │   └── architecture-diagram.png
│   │
│   ├── MAP_GUIDE.md                      # Guide for creating maps
│   ├── ARCHITECTURE.md                   # Architecture documentation
│   ├── DATABASE.md                       # Database schema docs
│   ├── CONTRIBUTING.md                   # Contribution guidelines
│   ├── CODE_OF_CONDUCT.md               # Code of conduct
│   └── DEVELOPMENT.md                    # Development guide
│
├── .github/                              # GitHub specific
│   ├── workflows/
│   ├── ISSUE_TEMPLATE/
│   │   ├── bug_report.md
│   │   └── feature_request.md
│   └── PULL_REQUEST_TEMPLATE.md
│
├── .gitignore                            # Git ignore rules
├── .gitattributes                        # Git attributes
├── .editorconfig                         # Editor configuration
├── global.json                           # .NET SDK version
├── LICENSE                               # MIT License
├── README.md                             # Main documentation
├── CHANGELOG.md                          # Version history
└── MazeChomperGame.sln                        # Solution file (optional)
```

---

## Directory Descriptions

### Root Level

| Directory/File | Description |
|----------------|-------------|
| `.github/` | GitHub-specific files (workflows, templates) |
| `src/` | All source code |
| `tests/` | Unit and integration tests |
| `tools/` | Development and build tools |
| `docs/` | Project documentation |
| `.gitignore` | Specifies intentionally untracked files |
| `.gitattributes` | Git attribute configuration |
| `.editorconfig` | Code style configuration |
| `global.json` | .NET SDK version lock |
| `LICENSE` | MIT License text |
| `README.md` | Project overview and quick start |
| `CHANGELOG.md` | Version history and changes |

### Source (`src/MazeChomperGame/`)

| Directory | Purpose | Examples |
|-----------|---------|----------|
| `Assets/` | Game resources | Sprites, audio, maps |
| `Models/` | Data structures | Pacman, Ghost, GameState |
| `ViewModels/` | MVVM logic | GameViewModel, MenuViewModel |
| `Views/` | UI definitions | GameView.axaml |
| `Services/` | Business logic | MapLoader, AudioManager, AI |
| `Helpers/` | Utilities | Constants, Extensions |
| `Styles/` | UI styling | ButtonStyles.axaml |

### Assets (`Assets/`)

| Subdirectory | Contents | Format |
|--------------|----------|--------|
| `Sprites/` | Sprite sheets + JSON maps | PNG, JSON |
| `Audio/Music/` | Background music | WAV |
| `Audio/SFX/` | Sound effects | WAV |
| `Maps/` | Level definitions | TXT |

### Services (`Services/`)

| Category | Components |
|----------|------------|
| **Core** | MapLoader, SpriteManager, AudioManager |
| **Game Logic** | GameEngine, CollisionDetector |
| **AI** | BlinkyAI, PinkyAI, InkyAI, ClydeAI |
| **Persistence** | ProfileManager |

---

## File Naming Conventions

### C# Files
- **Models:** `PascalCase.cs` (e.g., `Pacman.cs`)
- **ViewModels:** `PascalCaseViewModel.cs` (e.g., `GameViewModel.cs`)
- **Services:** `PascalCase.cs` (e.g., `MapLoader.cs`)
- **Interfaces:** `IPascalCase.cs` (e.g., `IMapLoader.cs`)

### AXAML Files
- **Views:** `PascalCaseView.axaml` (e.g., `GameView.axaml`)
- **Styles:** `PascalCaseStyles.axaml` (e.g., `ButtonStyles.axaml`)

### Assets
- **Sprites:** `lowercase-with-dashes.png` (e.g., `pacman-spritesheet.png`)
- **Audio:** `lowercase-with-dashes.wav` (e.g., `game-start.wav`)
- **Maps:** `levelX.txt` (e.g., `level1.txt`)

---

## Key Files Explained

### `Program.cs`
Entry point of the application. Sets up dependency injection and starts the app.

### `App.axaml` / `App.axaml.cs`
Application-level resources and configuration. Defines global styles and themes.

### `MainWindow.axaml`
Main application window. Contains navigation logic between different views.

### `GameView.axaml`
Main game screen. Contains the game canvas and HUD.

### `GameViewModel.cs`
Controls game logic, coordinates between services, manages game state.

### `GameEngine.cs`
Core game loop. Updates entities, checks collisions, manages timing.

### `MapLoader.cs`
Reads `.txt` map files and converts them to usable game data structures.

### `SpriteManager.cs`
Loads sprite sheets and provides sprite access via JSON mapping.

### `AudioManager.cs`
Manages all audio playback (music and sound effects).

### `CollisionDetector.cs`
Handles all collision detection between entities.

### `ProfileManager.cs`
Manages SQLite database operations for profiles, scores, and settings.

---

## Build Output

After building, additional directories will be created:

```
bin/                    # Compiled binaries
└── Debug/             # Debug build
    └── net9.0/
        └── ...

obj/                    # Intermediate build files
└── Debug/
    └── net9.0/
        └── ...
```

**Note:** These directories are ignored by Git (`.gitignore`).

---

## Data Files (Runtime)

During gameplay, the application will create:

```
%APPDATA%/MazeChomperGame/         # Windows
~/.config/MazeChomperGame/          # Linux
~/Library/Application Support/MazeChomperGame/  # macOS

├── profiles.db                # SQLite database (profiles, scores, settings)
└── logs/                      # Application logs
    └── app.log
```

---

## Asset Generation Output

When running asset generation scripts:

```
tools/AssetGeneration/output/
├── pacman_spritesheet.png
├── pacman_sprite_map.json
├── ghosts_spritesheet.png
├── ghosts_sprite_map.json
├── items_spritesheet.png
├── items_sprite_map.json
├── tiles_spritesheet.png
├── tiles_sprite_map.json
├── chomp.wav
├── death.wav
└── ...
```

These are then copied to `src/MazeChomperGame/Assets/`.

---

## Summary

- **Total Directories:** ~30
- **Source Files (estimated):** ~50 C# files + ~10 AXAML files
- **Asset Files:** ~25 (sprites, audio, maps)
- **Documentation Files:** ~10
- **Configuration Files:** ~5

**Total Project Size (estimated):**
- Source code: ~5-10 MB
- Assets: ~20-30 MB
- **Total:** ~30-40 MB

---

**Last Updated:** February 2026
**Project:** Arcade Maze Chomper Educational Recreation  
**Framework:** .NET 9.0 + Avalonia UI
