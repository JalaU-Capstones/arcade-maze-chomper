using System;
using System.Collections.Generic;
using MazeChomperGame.Models.Game;
using MazeChomperGame.Services.Interfaces;
using MazeChomperGame.ViewModels;

namespace MazeChomperGame.Models.Console;

public sealed class ConsoleContext
{
    public MainWindowViewModel MainWindowViewModel { get; }
    public Profile? ActiveProfile { get; }
    public IProfileManager ProfileManager { get; }
    public Func<IReadOnlyCollection<IConsoleCommand>> GetAvailableCommands { get; }

    public ConsoleContext(
        MainWindowViewModel mainWindowViewModel,
        Profile? activeProfile,
        IProfileManager profileManager,
        Func<IReadOnlyCollection<IConsoleCommand>> getAvailableCommands)
    {
        MainWindowViewModel = mainWindowViewModel;
        ActiveProfile = activeProfile;
        ProfileManager = profileManager;
        GetAvailableCommands = getAvailableCommands;
    }
}
