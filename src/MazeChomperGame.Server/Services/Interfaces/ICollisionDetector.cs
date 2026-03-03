using MazeChomperGame.Server.Models;
using MazeChomperGame.Shared;

namespace MazeChomperGame.Server.Services
{
    public interface ICollisionDetector
    {
        bool CanMove(Entity entity, Direction direction, TileType[,] map);
        bool IsWall(float x, float y, TileType[,] map);
    }
}
