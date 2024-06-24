namespace Calorium.Views;

public partial class Push_Pull_Legs : ContentPage
{
	public Push_Pull_Legs()
	{
		InitializeComponent();
	}

    private void pplVolumeBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Push_Pull_Legs_Beginner));
    }

    private void pplIntensityBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Push_Pull_Legs_Advanced));
    }

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChooseYourPlan());
    }
}