using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MazeChomperGame.ViewModels;

namespace MazeChomperGame.Views;

public partial class CustomLevelsLibraryView : UserControl
{
    public CustomLevelsLibraryView()
    {
        InitializeComponent();
    }

    public CustomLevelsLibraryViewModel? ViewModel => DataContext as CustomLevelsLibraryViewModel;

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
