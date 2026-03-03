using System;

namespace MazeChomperGame.Models.Game;

public sealed class KeyBindingEntry
{
    public long Id { get; set; }
    public int ProfileId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string KeyCode { get; set; } = string.Empty;
    public string? ModifierKeys { get; set; }
    public long CreatedAt { get; set; }
    public long UpdatedAt { get; set; }
}
