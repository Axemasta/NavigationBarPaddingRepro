using System.Diagnostics;
using Microsoft.Extensions.Logging;
using PrismApp.Pages;
using PrismApp.ViewModels;

namespace PrismApp;

internal static class PrismStartup
{
	public static void Configure(PrismAppBuilder builder)
	{
		builder
			.RegisterTypes(RegisterTypes)
			.CreateWindow(CreateWindow);
	}

	private static void RegisterTypes(IContainerRegistry containerRegistry)
	{
		containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
		containerRegistry.RegisterForNavigation<ModalPage, ModalViewModel>();
	}

	private static async Task CreateWindow(IContainerProvider containerProvider, INavigationService navigationService)
	{
		var nav = await navigationService.CreateBuilder()
			.AddNavigationPage().AddSegment<MainViewModel>()
			.NavigateAsync();

		if (!nav.Success)
		{
			var logger = containerProvider.Resolve<ILogger<App>>();
			logger.LogError(nav.Exception, "An exception occurred navigating to first page");
			Debugger.Break();
		}
	}
}