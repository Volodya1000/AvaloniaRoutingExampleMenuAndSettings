using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaRoutingExample.ViewModel;

namespace AvaloniaRoutingExample.UI.Views;

public partial class NotificationsSettingsControl : ReactiveUserControl<NotificationsSettingsViewModel>
{
    public NotificationsSettingsControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}