using ReactiveUI.Fody.Helpers;
using ReactiveUI;

namespace AvaloniaRoutingExample.ViewModel;

public class DisplaySettingsViewModel : ReactiveObject, IRoutableViewModel
{
    public string UrlPathSegment => "display";
    public IScreen HostScreen { get; }

    [Reactive]
    public bool IsFullScreen { get; set; }

    [Reactive]
    public string SelectedScale { get; set; }

    public List<string> AvailableScales { get; } = new() { "100%", "125%", "150%" };

    public DisplaySettingsViewModel(IScreen screen)
    {
        HostScreen = screen;
        SelectedScale = AvailableScales[0];
    }
}
