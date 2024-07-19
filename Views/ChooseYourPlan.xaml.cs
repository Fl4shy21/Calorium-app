using Calorium.Views;
using CommunityToolkit.Maui.Views;

namespace Calorium.Views;

public partial class ChooseYourPlan : ContentPage
{
	public ChooseYourPlan()
	{
		InitializeComponent();
	}

    private void beginnerBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ChooseYourPlan_Beginner));
    }

    private void advancedBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ChooseYourPlan_Advanced));
    }

    private void intermediateBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ChooseYourPlan_Intermediate));
    }
}