using MazeChomperGame.Shared;
using System.Collections.Generic;

namespace MazeChomperGame.Server.Models;

public class GameState
{
    public Dictionary<int, PlayerState> PlayerStates { get; set; } = new();
    public int Level { get; set; }
    public int Score { get; set; }
    public int Lives { get; set; }
}
