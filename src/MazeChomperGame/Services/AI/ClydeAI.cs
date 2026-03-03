using System;
using System.Collections.Generic;
using MazeChomperGame.Models.Entities;
using MazeChomperGame.Models.Enums;
using MazeChomperGame.Helpers;
using MazeChomperGame.Services.Pathfinding;
using Microsoft.Extensions.Logging;

namespace MazeChomperGame.Services.AI;

/// <summary>
/// Implements Clyde's AI behavior.
/// </summary>
public class ClydeAI : IGhostAI
{
    private readonly AStarPathfinder _pathfinder = new AStarPathfinder();

    /// <summary>
    /// Clyde's behavior is to chase Arcade Maze Chomper when far away, but scatter when close.
    /// </summary>
    public Direction GetNextMove(Ghost ghost, Pacman pacman, TileType[,] map, List<Ghost> allGhosts, bool isChaseMode, ILogger logger)
    {
        int targetY, targetX;

        if (isChaseMode)
        {
            // Chase Mode: Target depends on distance to Arcade Maze Chomper.
            double distance = Math.Sqrt(Math.Pow(ghost.X - pacman.X, 2) + Math.Pow(ghost.Y - pacman.Y, 2));

            if (distance > Constants.ClydeShyDistance)
            {
                // If far from Arcade Maze Chomper, chase directly (like Blinky).
                targetY = pacman.Y;
                targetX = pacman.X;
            }
            else
            {
                // If close to Arcade Maze Chomper, retreat to scatter target.
                targetY = Constants.ClydeScatterY;
                targetX = Constants.ClydeScatterX;
            }
        }
        else
        {
            // Scatter Mode: Target is the bottom-left corner.
            targetY = Constants.ClydeScatterY;
            targetX = Constants.ClydeScatterX;
        }

        var next = _pathfinder.FindPath(ghost.Y, ghost.X, targetY, targetX, map, ghost, logger);
        return next;
    }
}
