using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaRoutingExample.ViewModel;

public class GeneralSettingsViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }

    public string UrlPathSegment => "general";

    public GeneralSettingsViewModel(IScreen screen) => HostScreen = screen;

    [Reactive]
    public bool IsDarkModeEnabled { get; set; }

    [Reactive]
    public bool IsAutoUpdateEnabled { get; set; }
}
