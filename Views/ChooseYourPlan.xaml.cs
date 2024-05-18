using Calorium.Views;
using CommunityToolkit.Maui.Views;

namespace Calorium.Views;

public partial class ChooseYourPlan : ContentPage
{
	public ChooseYourPlan()
	{
		InitializeComponent();
	}

    private void PPLBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Push_Pull_Legs));
    }

    private void ArnoldBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ArnoldSplit));
    }

    private void HeavyDutyBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HeavyDuty));
    }

    private void BroSplit_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BroSplit));
    }
}