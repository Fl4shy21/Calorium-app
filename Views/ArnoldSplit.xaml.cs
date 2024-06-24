namespace Calorium.Views;

public partial class ArnoldSplit : ContentPage
{
	public ArnoldSplit()
	{
		InitializeComponent();
	}

    private async void arnoldVolumeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ArnoldSplit_Beginner());
    }

    private async void arnoldIntensityBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ArnoldSplit_Advanced());
    }

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChooseYourPlan());
    }
}