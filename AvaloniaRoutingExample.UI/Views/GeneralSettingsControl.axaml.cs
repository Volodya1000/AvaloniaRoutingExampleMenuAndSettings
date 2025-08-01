using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaRoutingExample.ViewModel;
namespace AvaloniaRoutingExample.UI.Views;

public partial class GeneralSettingsControl : ReactiveUserControl<GeneralSettingsViewModel>
{
    public GeneralSettingsControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}