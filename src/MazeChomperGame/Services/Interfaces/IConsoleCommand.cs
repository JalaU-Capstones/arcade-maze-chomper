using System.Collections.Generic;
using System.Threading.Tasks;
using MazeChomperGame.Models.Console;

namespace MazeChomperGame.Services.Interfaces;

public interface IConsoleCommand
{
    string Name { get; }
    string Syntax { get; }
    string Description { get; }
    IReadOnlyCollection<string> Aliases { get; }
    Task<ConsoleCommandResult> ExecuteAsync(string[] args, ConsoleContext context);
}
