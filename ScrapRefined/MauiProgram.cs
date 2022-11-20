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
        builder.Services.AddWMBSC();		//slider
        builder.Services.AddSingleton<ScrapRefinedDbContext>();
		builder.Services.AddSingleton<ProductRepository>();
		builder.Services.AddSingleton<IndexViewModel>();
		builder.Services.AddScoped<ProductDetailViewModel>();
        builder.Services.AddTransient<AddProductViewModel>();
        builder.Services.AddTransient<CategoryViewModel>();
        builder.Services.AddSingleton<ListObsevedViewModel>();
        return builder.Build();
	}
}
