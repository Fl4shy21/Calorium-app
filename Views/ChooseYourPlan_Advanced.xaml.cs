namespace Calorium.Views;

public partial class ChooseYourPlan_Advanced : ContentPage
{
	public ChooseYourPlan_Advanced()
	{
		InitializeComponent();
	}

    private async void PPLBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Push_Pull_Legs_Advanced());
    }

    private async void ArnoldBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ArnoldSplit_Advanced());
    }

    private async void heavydutyBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HeavyDuty());
    }
}