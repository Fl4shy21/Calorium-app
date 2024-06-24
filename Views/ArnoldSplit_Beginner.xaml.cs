namespace Calorium.Views;

public partial class ArnoldSplit_Beginner : ContentPage
{
	public ArnoldSplit_Beginner()
	{
		InitializeComponent();
	}

    private void backBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(ArnoldSplit));
    }
}