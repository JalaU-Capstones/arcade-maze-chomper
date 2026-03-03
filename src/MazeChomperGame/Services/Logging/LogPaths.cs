using System;
using System.IO;

namespace MazeChomperGame.Services.Logging;

internal static class LogPaths
{
    public static string GetLogFilePath()
    {
        // Match data-root conventions used elsewhere (ProfileManager/CustomLevelManagerService).
        string root;

        if (OperatingSystem.IsWindows())
        {
            root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArcadeMazeChomper");
        }
        else if (OperatingSystem.IsLinux())
        {
            var flatpakId = Environment.GetEnvironmentVariable("FLATPAK_ID");
            if (!string.IsNullOrEmpty(flatpakId))
            {
                root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "arcade-maze-chomper");
            }
            else
            {
                var xdg = Environment.GetEnvironmentVariable("XDG_DATA_HOME");
                if (string.IsNullOrEmpty(xdg))
                {
                    xdg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".local", "share");
                }
                root = Path.Combine(xdg, "arcade-maze-chomper");
            }
        }
        else
        {
            root = AppContext.BaseDirectory;
        }

        return Path.Combine(root, "logs", "pacman.log");
    }
}

