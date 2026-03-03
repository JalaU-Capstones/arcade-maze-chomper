using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MazeChomperGame.Views;

public partial class ProfileSelectionView : UserControl
{
    public ProfileSelectionView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
