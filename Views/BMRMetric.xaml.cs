namespace Calorium.Views;

public partial class BMRMetric : ContentPage
{
	public BMRMetric()
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
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else if (bFemale.IsChecked)
            {
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
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