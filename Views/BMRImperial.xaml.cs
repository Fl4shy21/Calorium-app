namespace Calorium.Views;

public partial class BMRImperial : ContentPage
{
	public BMRImperial()
	{
		InitializeComponent();
	}

	private void Calculate_Clicked(object sender, EventArgs e)
	{
        if (double.TryParse(eWeight.Text, out double weight) &&
        double.TryParse(eHeight.Text, out double height) &&
        int.TryParse(eAge.Text, out int age))
		{
			double bmr = 0;

			if (bMale.IsChecked)
			{
				bmr = 66.24 + (6.24 * weight) + (12.7 * height) - (6.75 * age);
			}
			else
			{
				bmr = 65.51 + (4.35 * weight) + (4.7 * height) - (4.7 * age);
			}

            double activityFactor = 1.0;
            if (rSedentary.IsChecked)
                activityFactor = 1.2;
            else if (rLightlyActive.IsChecked)
                activityFactor = 1.375;
            else if (rModeratelyActive.IsChecked)
                activityFactor = 1.55;
            else if (rVeryActive.IsChecked)
                activityFactor = 1.725;
            else if (rExtremelyActive.IsChecked)
                activityFactor = 1.9;

            double maintenanceCalories = bmr * activityFactor;
            lResult.Text = $"Maintenance Caloric Level: {maintenanceCalories:F2} per day";
        }
        else
        {
            lResult.Text = "Please enter valid values for weight, height, and age.";
        }
    }
}