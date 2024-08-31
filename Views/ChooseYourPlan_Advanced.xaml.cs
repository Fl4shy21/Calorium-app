namespace Calorium.Views;

public partial class ChooseYourPlan_Advanced : ContentPage
{
	public ChooseYourPlan_Advanced()
	{
		InitializeComponent();
	}

    private void PPLBtn_Clicked(object sender, EventArgs e)
    {
         Shell.Current.GoToAsync(nameof(Push_Pull_Legs_Advanced));
    }

    private void ArnoldBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ArnoldSplit_Advanced));
    }

    private void heavydutyBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HeavyDuty));
    }

    private void backBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChooseYourPlan());
    }
}