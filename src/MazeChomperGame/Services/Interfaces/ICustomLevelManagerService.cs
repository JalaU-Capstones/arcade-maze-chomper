using System.Collections.Generic;
using System.Threading.Tasks;
using MazeChomperGame.Models.CustomLevel;

namespace MazeChomperGame.Services.Interfaces;

public interface ICustomLevelManagerService
{
    Task<IReadOnlyList<CustomLevelSummary>> GetCustomLevelsAsync();
    Task<CustomLevelSummary> ImportProjectAsync(string filePath);
    Task DeleteCustomLevelAsync(string id);
}
