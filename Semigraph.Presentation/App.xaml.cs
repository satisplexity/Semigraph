using Semigraph.Presentation.Views.Windows;
using System.Windows;

namespace Semigraph.Presentation;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs arguments)
    {
        base.OnStartup(arguments);

        ShowWindow();
    }

    private void ShowWindow()
    {
        MainWindow window = new();

        window.Show();
    }
}