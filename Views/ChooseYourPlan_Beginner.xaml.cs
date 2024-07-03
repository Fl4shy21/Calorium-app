namespace Calorium.Views;

public partial class ChooseYourPlan_Beginner : ContentPage
{
	public ChooseYourPlan_Beginner()
	{
		InitializeComponent();
	}

    private async void PPLBtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Push_Pull_Legs_Beginner());
    }

    private async void ArnoldBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ArnoldSplit_Beginner());
    }

    private async void brosplitBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BroSplit());
    }
}