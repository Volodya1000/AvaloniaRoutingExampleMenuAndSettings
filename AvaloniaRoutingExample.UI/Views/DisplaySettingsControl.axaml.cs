using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaRoutingExample.ViewModel;

namespace AvaloniaRoutingExample.UI.Views;

public partial class DisplaySettingsControl:ReactiveUserControl<DisplaySettingsViewModel>
{
    public DisplaySettingsControl()
    {
         AvaloniaXamlLoader.Load(this);
    }
}