namespace Calorium.Views;

public partial class ChooseYourPlan_Intermediate : ContentPage
{
	public ChooseYourPlan_Intermediate()
	{
		InitializeComponent();
	}

    private void PPLBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Push_Pull_Legs_Intermediate());
    }

    private void backBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChooseYourPlan());
    }
}