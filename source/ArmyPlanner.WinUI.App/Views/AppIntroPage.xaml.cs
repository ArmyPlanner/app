using ArmyPlanner.WinUI.App.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ArmyPlanner.WinUI.App.Views;

public sealed partial class AppIntroPage : Page
{
    public AppIntroViewModel ViewModel
    {
        get;
    }

    public AppIntroPage()
    {
        ViewModel = App.GetService<AppIntroViewModel>();
        InitializeComponent();
    }
}
