using Microsoft.Maui.Controls;
using System;
using System.Linq;
using ZXing.Net.Maui;

namespace Calorium.Views
{
    public partial class QRScanner : ContentPage
    {
        private string scannedURL;
        private bool isPopupDisplayed = false;

        public QRScanner()
        {
            InitializeComponent();
            barcodeReader.Options = new BarcodeReaderOptions()
            {
                Formats = BarcodeFormat.QrCode,
                AutoRotate = true,
                Multiple = true
            };
        }

        private void CameraBarcodeReaderView_BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
        {
            var first = e.Results.FirstOrDefault();

            if (first is null || isPopupDisplayed)
                return;

            scannedURL = first.Value;
            isPopupDisplayed = true;

            Dispatcher.DispatchAsync(async () =>
            {
                barcodeResult.Text = scannedURL;
                linkBtn.IsVisible = true;
                await DisplayAlert("Barcode Detected", scannedURL, "OK");
                isPopupDisplayed = false;
            });
        }

        private async void BackToMenuBtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MenuPage");
        }

        private async void linkBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(scannedURL))
            {
                await Launcher.OpenAsync(new Uri(scannedURL));
            }
        }
    }
}