using CommunityToolkit.Mvvm.ComponentModel;

namespace PrismApp.ViewModels;

public class BaseViewModel(INavigationService navigationService) : ObservableObject
{
    // ReSharper disable once InconsistentNaming
    protected INavigationService navigationService { get; } = navigationService;
}