namespace Calorium.Views;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

    private async void CaloriumURL_Tapped(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://fl4shy21.github.io/Calorium/");
    }
}