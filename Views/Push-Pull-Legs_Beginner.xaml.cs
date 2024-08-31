namespace Calorium.Views;

public partial class Push_Pull_Legs_Beginner : ContentPage
{
	public Push_Pull_Legs_Beginner()
	{
		InitializeComponent();
	}

    private void backBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ChooseYourPlan_Beginner());
    }
}