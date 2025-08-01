using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaRoutingExample.ViewModel;
using ReactiveUI;

namespace AvaloniaRoutingExample.UI.Views;

public partial class MainWindow: ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}