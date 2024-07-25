using Calorium.Models;
using System.Diagnostics;

namespace Calorium.Views;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
	}

    private async void GoToCalorium_Clicked(object sender, EventArgs e)
    {
        if (Shell.Current != null)
        {
            await Shell.Current.GoToAsync($"//{nameof(MenuPage)}");
        }
        else
        {
            Debug.WriteLine("Shell.Current is null!");
        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://fl4shy21.github.io/Calorium/");
    }
}