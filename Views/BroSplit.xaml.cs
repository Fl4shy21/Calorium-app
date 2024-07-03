namespace Calorium.Views;

public partial class BroSplit : ContentPage
{
	public BroSplit()
	{
		InitializeComponent();
	}
    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChooseYourPlan_Beginner());
    }
}