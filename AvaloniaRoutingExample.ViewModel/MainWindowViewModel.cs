using AvaloniaRoutingExample.ViewModel;
using ReactiveUI.Fody.Helpers;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

namespace AvaloniaRoutingExample.ViewModel;

public class MainWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new();

    public ObservableCollection<SectionItemViewModel> SettingsSections { get; }

    [Reactive]
    public SectionItemViewModel? CurrentSection { get; private set; }

    public ReactiveCommand<SectionItemViewModel, Unit> NavigateToSectionCommand { get; }

    public MainWindowViewModel()
    {
        SettingsSections = new ObservableCollection<SectionItemViewModel>
        {
            new(new GeneralSettingsViewModel(this)),
            new(new NotificationsSettingsViewModel(this)),
            new(new DisplaySettingsViewModel(this))
        };

        NavigateToSectionCommand = ReactiveCommand.Create<SectionItemViewModel>(section =>
        {
            Router.Navigate.Execute(section.ViewModel);
            CurrentSection = section;
        });

        // Автоматическое выделение текущего раздела
        this.WhenAnyValue(x => x.CurrentSection)
            .Subscribe(current =>
            {
                foreach (var section in SettingsSections)
                    section.IsSelected = section == current;
            });

        // Навигация по умолчанию
        CurrentSection = SettingsSections.First();
        Router.Navigate.Execute(CurrentSection.ViewModel).Subscribe();
    }
}