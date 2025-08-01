using AvaloniaRoutingExample.ViewModel;
using ReactiveUI.Fody.Helpers;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

namespace AvaloniaRoutingExample.ViewModel;

public class MainWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new();

    public ObservableCollection<IRoutableViewModel> SettingsSections { get; }

    [Reactive]
    public IRoutableViewModel? CurrentSection { get; set; }

    public ReactiveCommand<IRoutableViewModel, Unit> NavigateToSectionCommand { get; }

    public MainWindowViewModel()
    {
        SettingsSections = new ObservableCollection<IRoutableViewModel>
        {
            new GeneralSettingsViewModel(this),
            new NotificationsSettingsViewModel(this),
            new DisplaySettingsViewModel(this)
        };

        NavigateToSectionCommand = ReactiveCommand.Create<IRoutableViewModel>(section =>
        {
            Router.Navigate.Execute(section);
            CurrentSection = section;
        });

        CurrentSection = SettingsSections[0];
        Router.Navigate.Execute(CurrentSection).Subscribe();
    }
}
