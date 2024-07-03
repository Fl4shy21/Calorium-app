namespace Calorium.Views;

public partial class ArnoldSplit_Advanced : ContentPage
{
	public ArnoldSplit_Advanced()
	{
		InitializeComponent();
	}

    private void backBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ChooseYourPlan_Advanced));
    }
}