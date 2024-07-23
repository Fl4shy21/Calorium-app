namespace Calorium.Views;

public partial class ArnoldSplit_Advanced : ContentPage
{
	public ArnoldSplit_Advanced()
	{
		InitializeComponent();
	}

    private void backBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChooseYourPlan_Advanced());
    }
}