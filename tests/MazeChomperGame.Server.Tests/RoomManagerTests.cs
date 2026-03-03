using Xunit;
using MazeChomperGame.Server;
using MazeChomperGame.Server.Models;
using MazeChomperGame.Shared;
using System.Linq;

namespace MazeChomperGame.Server.Tests;

public class RoomManagerTests
{
    [Fact]
    public void CreateRoom_ReturnsNewRoom()
    {
        // Arrange
        var manager = new RoomManager();

        // Act
        var room = manager.CreateRoom("TestRoom", null, RoomVisibility.Public);

        // Assert
        Assert.NotNull(room);
        Assert.Equal("TestRoom", room.Name);
        Assert.Empty(room.Players);
    }
}
