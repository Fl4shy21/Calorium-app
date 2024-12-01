namespace Calorium.Views;

public partial class ChooseYourPlan_Beginner : ContentPage
{
	public ChooseYourPlan_Beginner()
	{
		InitializeComponent();
	}

    private void PPLBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Push_Pull_Legs_Beginner));
    }

    private void ArnoldBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ArnoldSplit_Beginner));
    }

    private void backBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChooseYourPlan());
    }
}