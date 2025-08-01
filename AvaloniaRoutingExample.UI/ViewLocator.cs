using System;
using AvaloniaRoutingExample.UI.Views;
using AvaloniaRoutingExample.ViewModel;
using ReactiveUI;

namespace AvaloniaRoutingExample.UI;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T viewModel, string contract = null)
    {
        var viewModelType = viewModel?.GetType();
        if (viewModelType == null) return null;

        // Преобразуем например "AvaloniaRoutingExample.ViewModel.GeneralSettingsViewModel"
        // в "AvaloniaRoutingExample.UI.Views.GeneralSettingsControl"
        var viewTypeName = viewModelType.FullName
            ?.Replace(".ViewModel.", ".UI.Views.")
            ?.Replace("ViewModel", "Control");

        if (viewTypeName == null)
            return null;

        var viewType = Type.GetType(viewTypeName);
        if (viewType == null)
            return null;

        var view = Activator.CreateInstance(viewType);
        if (view is IViewFor viewFor)
        {
            viewFor.ViewModel = viewModel;
            return viewFor;
        }

        return null;
    }
}
