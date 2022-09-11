using Microsoft.Maui.Controls.Compatibility.Hosting;
using Xamarin.CommunityToolkit.Android.Effects;
using Xamarin.CommunityToolkit.Effects;

namespace MyTouchEffect;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
    .UseMauiCompatibility()
    .ConfigureMauiHandlers(handlers =>
    {
        // Register ALL handlers in the Xamarin Community Toolkit assembly
        handlers.AddCompatibilityRenderers(typeof(Xamarin.CommunityToolkit.Effects.TouchEffect).Assembly);
    })
    .ConfigureEffects(effects =>
    {
        effects.AddCompatibilityEffects(typeof(Xamarin.CommunityToolkit.Effects.TouchEffect).Assembly);
        // effects.Add(typeof(TouchEffect), typeof(PlatformTouchEffect));
    })
    .ConfigureFonts(fonts =>
    {
        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
    });
        return builder.Build();
    }
}