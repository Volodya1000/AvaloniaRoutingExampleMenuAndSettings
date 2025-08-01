using System;
using AvaloniaRoutingExample.UI.Views;
using AvaloniaRoutingExample.ViewModel;
using ReactiveUI;

namespace AvaloniaRoutingExample.UI;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
    {
        NotificationsSettingsViewModel context => new NotificationsSettingsControl { DataContext = context },
        GeneralSettingsViewModel context => new GeneralSettingsControl { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}
