using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaRoutingExample.ViewModel;

public class SectionItemViewModel : ReactiveObject
{
    public IRoutableViewModel ViewModel { get; }

    public SectionItemViewModel(IRoutableViewModel vm)
    {
        ViewModel = vm;
    }

    [Reactive]
    public bool IsSelected { get; set; }

    // проброс свойства для кнопки, чтобы в XAML было Content="{Binding UrlPathSegment}"
    public string UrlPathSegment => ViewModel.UrlPathSegment;
}