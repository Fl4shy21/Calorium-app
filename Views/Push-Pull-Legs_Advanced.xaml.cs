namespace Calorium.Views;

public partial class Push_Pull_Legs_Advanced : ContentPage
{
	public Push_Pull_Legs_Advanced()
	{
		InitializeComponent();
	}

    private void backBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ChooseYourPlan_Advanced());
	}
}