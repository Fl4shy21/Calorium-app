namespace Calorium.Views;

public partial class ContactCreator : ContentPage
{
	public ContactCreator()
	{
		InitializeComponent();
	}

    private async void YouTubebtn_Tapped(object sender, TappedEventArgs e)
    {
		await Launcher.OpenAsync("https://www.youtube.com/channel/UC8Mxc3HgeR6yGExpqpF_3GQ");
    }

    private async void FiverrURL_Tapped(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.fiverr.com/fl4shy_21?up_rollout=true");
    }

    private async void cancelBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MenuPage");
    }
}