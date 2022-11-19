using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.EntityFrameworkCore;
using ScrapRefined.DAL;
using ScrapRefined.Data;
using ScrapRefined.ViewModels;

namespace ScrapRefined;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<ScrapRefinedDbContext>();
		builder.Services.AddSingleton<ProductRepository>();
		builder.Services.AddSingleton<IndexViewModel>();
		builder.Services.AddTransient<ProductDetailViewModel>();
        //builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
	}
}
