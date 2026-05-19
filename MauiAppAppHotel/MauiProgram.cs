using System.Runtime.Versioning;

namespace MauiAppAppHotel;

public static class MauiProgram
{
    [SupportedOSPlatform("windows10.0.17763.0")]
    [SupportedOSPlatform("android21.0")]
    [SupportedOSPlatform("ios11.0")]
    [SupportedOSPlatform("maccatalyst13.1")]
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                fonts.AddFont("Kalam-Regular.ttf", "Kalam");
            });

        return builder.Build();
    }
}
