using CommunityToolkit.Mvvm.Input;

namespace PrismApp.ViewModels;

public partial class MainViewModel(INavigationService navigationService) : BaseViewModel(navigationService)
{
    [RelayCommand]
    private async Task ShowModal()
    {
        await navigationService.CreateBuilder()
            .AddNavigationPage(useModalNavigation: true)
            .AddSegment<ModalViewModel>()
            .NavigateAsync();
    }
}