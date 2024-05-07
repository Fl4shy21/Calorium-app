using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Camera.MAUI;
using ZXing.Net.Maui.Controls;


namespace Calorium
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCameraView()
                .UseBarcodeReader()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Altone Trial-Regular.ttf", "AltoneRegular");
                    fonts.AddFont("Altone Trial-Bold.ttf", "AltoneBold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
