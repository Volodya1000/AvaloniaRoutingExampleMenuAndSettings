using ReactiveUI.Fody.Helpers;
using ReactiveUI;

namespace AvaloniaRoutingExample.ViewModel;

public class NotificationsSettingsViewModel : ReactiveObject, IRoutableViewModel
{
    public string UrlPathSegment => "notifications";
    public IScreen HostScreen { get; }

    [Reactive]
    public bool IsEmailEnabled { get; set; }

    [Reactive]
    public bool IsPushEnabled { get; set; }

    public NotificationsSettingsViewModel(IScreen screen) => HostScreen = screen;
}