using System.Threading.Tasks;
using MazeChomperGame.Models.Console;

namespace MazeChomperGame.Services.ConsoleCommands;

public class ClearCommand : ConsoleCommandBase
{
    public override string Name => "clear";
    public override string Syntax => "/clear";
    public override string Description => "Clear the console history.";

    public override Task<ConsoleCommandResult> ExecuteAsync(string[] args, ConsoleContext context)
    {
        return Task.FromResult(new ConsoleCommandResult
        {
            Message = string.Empty,
            MessageType = ConsoleMessageType.Info,
            ClearHistory = true
        });
    }
}
