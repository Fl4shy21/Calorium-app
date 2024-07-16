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
            if (double.TryParse(eBMR.Text, out double BMR))
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

        private void CalculateMetric_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(eWeightMetric.Text, out double weight) &&
                double.TryParse(eHeightMetric.Text, out double height) &&
                int.TryParse(eAgeMetric.Text, out int age))
            {
                double bmr = 0;

                if (bMaleMetric.IsChecked)
                {
                    bmr = 10 * weight + 6.25 * height - 5 * age + 5;
                }
                else if (bFemaleMetric.IsChecked)
                {
                    bmr = 10 * weight + 6.25 * height - 5 * age - 161;
                }

                double activityFactor = 1.0;
                if (rSedentaryMetric.IsChecked)
                    activityFactor = 1.2;
                else if (rLightlyActiveMetric.IsChecked)
                    activityFactor = 1.375;
                else if (rModeratelyActiveMetric.IsChecked)
                    activityFactor = 1.55;
                else if (rVeryActiveMetric.IsChecked)
                    activityFactor = 1.725;
                else if (rExtremelyActiveMetric.IsChecked)
                    activityFactor = 1.9;

                double maintenanceCalories = bmr * activityFactor;
                lResultMetric.Text = $"Maintenance Caloric Level: {maintenanceCalories:F2} per day";
            }
            else
            {
                lResultMetric.Text = "Please enter valid values for weight, height, and age.";
            }
        }

        private void CalculateImperial_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(eWeightImperial.Text, out double weight) &&
            double.TryParse(eHeightImperial.Text, out double height) &&
            int.TryParse(eAgeImperial.Text, out int age))
            {
                double bmr = 0;

                if (bMaleImperial.IsChecked)
                {
                    bmr = 66.24 + (6.24 * weight) + (12.7 * height) - (6.75 * age);
                }
                else
                {
                    bmr = 65.51 + (4.35 * weight) + (4.7 * height) - (4.7 * age);
                }

                double activityFactor = 1.0;
                if (rSedentaryImperial.IsChecked)
                    activityFactor = 1.2;
                else if (rLightlyActiveImperial.IsChecked)
                    activityFactor = 1.375;
                else if (rModeratelyActiveImperial.IsChecked)
                    activityFactor = 1.55;
                else if (rVeryActiveImperial.IsChecked)
                    activityFactor = 1.725;
                else if (rExtremelyActiveImperial.IsChecked)
                    activityFactor = 1.9;

                double maintenanceCalories = bmr * activityFactor;
                lResultImperial.Text = $"Maintenance Caloric Level: {maintenanceCalories:F2} per day";
            }
            else
            {
                lResultImperial.Text = "Please enter valid values for weight, height, and age.";
            }
        }


        private void caloricBtn_Clicked(object sender, EventArgs e)
        {
            dailyCalculator.IsVisible = !dailyCalculator.IsVisible;
            macroCalculatorContent.IsVisible = false;
            metricBMR.IsVisible = false;
            imperialBMR.IsVisible = false;
        }

        private void OnMealsPickerChanged(object sender, EventArgs e)
        {
            GenerateEntries(mealsLayout, mealsPicker.SelectedIndex + 1, "Calories of meal #");
        }

        private void OnSnacksPickerChanged(object sender, EventArgs e)
        {
            GenerateEntries(snacksLayout, snacksPicker.SelectedIndex, "Calories of snack #");

        }

        private void GenerateEntries(Microsoft.Maui.Controls.StackLayout layout, int count, string placeholder)
        {
            layout.Children.Clear();
            for (int i = 1; i <= count; i++)
            {
                layout.Children.Add(new Entry { Placeholder = $"{placeholder} {i}", Keyboard = Keyboard.Numeric, TextColor = Colors.Black, PlaceholderColor = Colors.Grey });
            }
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (!int.TryParse(dailyGoalEntry.Text, out int dailyGoal))
            {
                DisplayAlert("Error", "Please enter a valid daily caloric goal.", "OK");
                return;
            }

            int totalCalories = 0;
            totalCalories += GetTotalCalories(mealsLayout);
            totalCalories += GetTotalCalories(snacksLayout);

            int remainingCalories = dailyGoal - totalCalories;
            remainingCaloriesLabel.Text = $"Remaining Calories: {remainingCalories}";
        }

        private int GetTotalCalories(Microsoft.Maui.Controls.StackLayout layout)
        {
            int total = 0;
            foreach (var child in layout.Children)
            {
                if (child is Entry entry && int.TryParse(entry.Text, out int calories))
                {
                    total += calories;
                }
            }
            return total;
        }
        private void BMRBtn_Pressed(object sender, EventArgs e)
        {
            ChooseMetric.IsVisible = !ChooseMetric.IsVisible;
            ChooseImperial.IsVisible = !ChooseImperial.IsVisible;
            macroCalculatorContent.IsVisible = false;
            dailyCalculator.IsVisible = false;
            BMRBtn.BackgroundColor = Colors.LightBlue;
        }

        private void BMRBtn_Released(object sender, EventArgs e)
        {
            BMRBtn.BackgroundColor = Colors.LightBlue;
            macroBtn.BackgroundColor = Colors.LightGreen;
            caloricBtn.BackgroundColor = Colors.LightGreen;
        }

        private void ChooseImperial_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                metricBMR.IsVisible = false;
                imperialBMR.IsVisible = true;
            }
        }

        private void ChooseMetric_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                imperialBMR.IsVisible = false;
                metricBMR.IsVisible = true;
            }
        }

        private void caloricBtn_Pressed(object sender, EventArgs e)
        {
            dailyCalculator.IsVisible = !dailyCalculator.IsVisible;
            macroCalculatorContent.IsVisible = false;
            metricBMR.IsVisible = false;
            imperialBMR.IsVisible = false;
            ChooseMetric.IsVisible = false;
            ChooseImperial.IsVisible = false;
            caloricBtn.BackgroundColor = Colors.LightBlue;
        }

        private void caloricBtn_Released(object sender, EventArgs e)
        {
            caloricBtn.BackgroundColor = Colors.LightBlue;
            macroBtn.BackgroundColor = Colors.LightGreen;
            BMRBtn.BackgroundColor = Colors.LightGreen;
        }

        private void macroBtn_Pressed(object sender, EventArgs e)
        {
            macroCalculatorContent.IsVisible = !macroCalculatorContent.IsVisible;
            dailyCalculator.IsVisible = false;
            metricBMR.IsVisible = false;
            imperialBMR.IsVisible = false;
            ChooseMetric.IsVisible = false;
            ChooseImperial.IsVisible = false;
            macroBtn.BackgroundColor = Colors.LightBlue;
        }

        private void macroBtn_Released(object sender, EventArgs e)
        {
            macroBtn.BackgroundColor = Colors.LightBlue;
            BMRBtn.BackgroundColor= Colors.LightGreen;
            caloricBtn.BackgroundColor = Colors.LightGreen;
        }
    }
}