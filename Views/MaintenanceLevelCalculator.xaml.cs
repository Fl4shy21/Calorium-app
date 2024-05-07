using Microsoft.Maui.Controls;
using System;

namespace Calorium.Views
{
    public partial class MaintenanceLevelCalculator : ContentPage
    {
        public MaintenanceLevelCalculator()
        {
            InitializeComponent();
        }

        private void proteinfatcarbsBtn_Clicked(object sender, EventArgs e)
        {
            if(double.TryParse(eBMR.Text, out double BMR))
            {
                double carbs = 0.60 * BMR;
                double protein = 0.25 * BMR;
                double fats = 0.15 * BMR;

                double carbsingrams = carbs / 4;
                double proteiningrams = protein / 4;
                double fatsingrams = fats / 9;

                carbsResult.Text = $"Carbs: {carbs:F2} calories per day \n {carbsingrams:F2} grams/day";
                proteinResult.Text = $"Protein: {protein:F2} calories/day \n {proteiningrams:F2} grams/day";
                fatsResult.Text = $"Fats: {fats:F2} calories/day \n {fatsingrams:F2} grams/day";
            }
            else
            {
                carbsResult.Text = "Couldn't fetch the result for carbs...please try again!";
                proteinResult.Text = "Couldn't fetch the result for protein...please try again!";
                fatsResult.Text = "Couldn't fetch the result for fats...please try again!";
            }
        }
        private void metricBtn_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(BMRMetric));
        }

        private void imperialBtn_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(BMRImperial));
        }
    }
}
