namespace Calorium.Views;

public partial class HeavyDuty : ContentPage
{
	public HeavyDuty()
	{
		InitializeComponent();
	}

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ChooseYourPlan_Advanced());
    }
}