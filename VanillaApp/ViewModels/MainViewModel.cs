using CommunityToolkit.Mvvm.Input;
using VanillaApp.Pages;

namespace VanillaApp.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public required INavigation Navigation { get; set; }
    
    [RelayCommand]
    private async Task ShowModal()
    {
        var modalPage = new ModalPage()
        {
            BindingContext = new ModalViewModel(),
        };
        
        await Navigation.PushModalAsync(new NavigationPage(modalPage));
    }
}