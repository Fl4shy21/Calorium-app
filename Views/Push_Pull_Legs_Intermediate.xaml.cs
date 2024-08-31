namespace Calorium.Views;

public partial class Push_Pull_Legs_Intermediate : ContentPage
{
	public Push_Pull_Legs_Intermediate()
	{
		InitializeComponent();
	}

    private void backBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ChooseYourPlan_Intermediate());
    }
}