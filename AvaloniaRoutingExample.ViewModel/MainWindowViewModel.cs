using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;

namespace AvaloniaRoutingExample.ViewModel;

public class MainWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new RoutingState();

    public ObservableCollection<IRoutableViewModel> SettingsSections { get; }

    public ReactiveCommand<IRoutableViewModel, Unit> NavigateToSectionCommand { get; }

    [Reactive]
    public IRoutableViewModel? CurrentSection { get; private set; }

    public MainWindowViewModel()
    {
        SettingsSections = new ObservableCollection<IRoutableViewModel>
        {
            new GeneralSettingsViewModel(this),
            new NotificationsSettingsViewModel(this)
        };

        NavigateToSectionCommand = ReactiveCommand.CreateFromTask<IRoutableViewModel>(async vm =>
        {
            await Router.Navigate.Execute(vm);
            CurrentSection = vm;
        });

        NavigateToSectionCommand.Execute(SettingsSections.First()).Subscribe();
    }
}

