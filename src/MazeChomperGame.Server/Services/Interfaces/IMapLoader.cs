using System.Collections.Generic;
using MazeChomperGame.Server.Models;

namespace MazeChomperGame.Server.Services
{
    public interface IMapLoader
    {
        TileType[,] LoadMap(string mapName);
        (int Row, int Col) GetPacmanSpawn(string mapName);
        List<(int Row, int Col)> GetGhostSpawns(string mapName);
        List<Collectible> GetCollectibles(string mapName);
    }
}
