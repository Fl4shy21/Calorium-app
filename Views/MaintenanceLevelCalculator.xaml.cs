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

        private void metricBtn_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(BMRMetric));
        }

        private void imperialBtn_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(BMRImperial));
        }

        private void macroBtn_Clicked(object sender, EventArgs e)
        {
            macroCalculatorContent.IsVisible = !macroCalculatorContent.IsVisible;
            dailyCalculator.IsVisible = false;
        }

        private void caloricBtn_Clicked(object sender, EventArgs e)
        {
            dailyCalculator.IsVisible = !dailyCalculator.IsVisible;
            macroCalculatorContent.IsVisible = false;
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
                layout.Children.Add(new Entry { Placeholder = $"{placeholder} {i}", Keyboard = Keyboard.Numeric, TextColor = Colors.Black, PlaceholderColor = Colors.Grey});
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
    }
}