namespace Calorium.Views;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var url = "https://fl4shy21.github.io/Calorium/"; 
        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL", "OK");
        }
    }
}