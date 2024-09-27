using VanillaApp.Pages;
using VanillaApp.ViewModels;

namespace VanillaApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var mainPage = new MainPage();
        mainPage.BindingContext = new MainViewModel()
        {
            Navigation = mainPage.Navigation
        };

        MainPage = new NavigationPage(mainPage);
    }
}