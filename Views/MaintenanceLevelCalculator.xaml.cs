using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using Plugin.Maui.Calendar.Models;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Calorium.Views
{
    public partial class MaintenanceLevelCalculator : ContentPage, INotifyPropertyChanged
    {
        private DateTime? selectedDate;
        private Dictionary<DateTime, int> caloricIntakeByDate = new Dictionary<DateTime, int>();
        private Dictionary<DateTime, (int calories, int carbs, int proteins, int fats)> nutrientIntakeByDate = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime? SelectedDate
        {
            get => selectedDate;
            set
            {
                if (selectedDate != value)
                {
                    selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                    OnDateSelected(selectedDate);
                }
            }
        }
        public MaintenanceLevelCalculator()
        {
            InitializeComponent();
            BindingContext = this;

            selectedDate = DateTime.Today;
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void ChangeShadowColor(Button button, Color color)
        {
            button.Shadow = new Shadow
            {
                Brush = new SolidColorBrush(color),
                Offset = new Point(5, 5),
                Radius = 25
            };
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

        private void OnMealsPickerChanged(object sender, EventArgs e)
        {
            GenerateEntries(mealsLayout, mealsPicker.SelectedIndex + 1, "Calories of meal #");
        }

        private void OnSnacksPickerChanged(object sender, EventArgs e)
        {
            GenerateEntries(snacksLayout, snacksPicker.SelectedIndex, "Calories of snack #");
        }

        private void GenerateEntries(Microsoft.Maui.Controls.StackLayout layout, int count, string type)
        {
            layout.Children.Clear();
            for (int i = 1; i <= count; i++)
            {
                layout.Children.Add(new Entry { Placeholder = $"{type} #{i} Calories", Keyboard = Keyboard.Numeric, TextColor = Colors.Black, PlaceholderColor = Colors.Grey });
                layout.Children.Add(new Entry { Placeholder = $"{type} #{i} Carbs (g)", Keyboard = Keyboard.Numeric, TextColor = Colors.Black, PlaceholderColor = Colors.Grey });
                layout.Children.Add(new Entry { Placeholder = $"{type} #{i} Protein (g)", Keyboard = Keyboard.Numeric, TextColor = Colors.Black, PlaceholderColor = Colors.Grey });
                layout.Children.Add(new Entry { Placeholder = $"{type} #{i} Fats (g)", Keyboard = Keyboard.Numeric, TextColor = Colors.Black, PlaceholderColor = Colors.Grey });
            }
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (!int.TryParse(dailyCaloricGoalEntry.Text, out int dailyCaloricGoal) ||
                !int.TryParse(dailyCarbsGoalEntry.Text, out int dailyCarbsGoal) ||
                !int.TryParse(dailyProteinGoalEntry.Text, out int DailyProteinGoal) ||
                !int.TryParse(dailyFatsGoalEntry.Text, out int DailyFatsGoal))
            {
                DisplayAlert("Error", "Please make sure that you entered valid numbers for your goals.", "OK");
                return;
            }

            int totalCalories = 0, totalCarbs = 0, totalProtein = 0, totalFats = 0;

            totalCalories += GetTotalNutrient(mealsLayout, 0);
            totalCarbs += GetTotalNutrient(mealsLayout, 1);
            totalProtein += GetTotalNutrient(mealsLayout, 2);
            totalFats += GetTotalNutrient(mealsLayout, 3);

            totalCalories += GetTotalNutrient(snacksLayout, 0);
            totalCarbs += GetTotalNutrient(snacksLayout, 1);
            totalProtein += GetTotalNutrient(snacksLayout, 2);
            totalFats += GetTotalNutrient(snacksLayout, 3);

            int remainingCalories = dailyCaloricGoal - totalCalories;
            int remainingCarbs = dailyCarbsGoal - totalCarbs;
            int remainingProteins = DailyProteinGoal - totalProtein;
            int remainingFats = DailyFatsGoal - totalFats;

            remainingNutrientsLabel.Text = $"Remaining Calories: {remainingCalories}\n" +
                                           $"Remaining Carbs: {remainingCarbs}g\n" +
                                           $"Remaining Proteins: {remainingProteins}g\n" +
                                           $"Remaining Fats: {remainingFats}g\n";

            var selectedDate = calendar.SelectedDate.HasValue ? calendar.SelectedDate.Value : DateTime.Today;
            nutrientIntakeByDate[selectedDate] = (totalCalories, totalCarbs, totalProtein, totalFats);
        }

        private int GetTotalNutrient(StackLayout layout, int nutrientIndex)
        {
            int total = 0;
            for (int i = nutrientIndex; i < layout.Children.Count; i += 4)
            {
                if (layout.Children[i] is Entry entry && int.TryParse(entry.Text, out int value))
                {
                    total += value;
                }
            }
            return total;
        }
        private void OnDateSelected(DateTime? date)
        {
            if (date.HasValue && caloricIntakeByDate.TryGetValue(date.Value, out int totalCalories))
            {
                DisplayAlert("Caloric Intake", $"Total calories for {date.Value.ToShortDateString()}: {totalCalories}", "OK");
            }
            else
            {
                DisplayAlert("Caloric Intake", $"No data available for {date?.ToShortDateString()}", "OK");
            }
        }
        private void BMRBtn_Pressed(object sender, EventArgs e)
        {
            ChooseMetric.IsVisible = !ChooseMetric.IsVisible;
            ChooseImperial.IsVisible = !ChooseImperial.IsVisible;
            macroCalculatorContent.IsVisible = false;
            dailyCalculator.IsVisible = false;
            BMRBtn.BackgroundColor = Color.FromRgb(15, 209, 173);
        }

        private void BMRBtn_Released(object sender, EventArgs e)
        {
            BMRBtn.BackgroundColor = Color.FromRgb(15, 209, 173);
            macroBtn.BackgroundColor = Color.FromRgb(124, 230, 163);
            caloricBtn.BackgroundColor = Color.FromRgb(124, 230, 163);
            metricBMR.IsVisible = false;
            imperialBMR.IsVisible = false;
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
            caloricBtn.BackgroundColor = Color.FromRgb(15, 209, 173);
        }

        private void caloricBtn_Released(object sender, EventArgs e)
        {
            caloricBtn.BackgroundColor = Color.FromRgb(15, 209, 173);
            macroBtn.BackgroundColor = Color.FromRgb(124, 230, 163);
            BMRBtn.BackgroundColor = Color.FromRgb(124, 230, 163);
        }

        private void macroBtn_Pressed(object sender, EventArgs e)
        {
            macroCalculatorContent.IsVisible = !macroCalculatorContent.IsVisible;
            dailyCalculator.IsVisible = false;
            metricBMR.IsVisible = false;
            imperialBMR.IsVisible = false;
            ChooseMetric.IsVisible = false;
            ChooseImperial.IsVisible = false;
            macroBtn.BackgroundColor = Color.FromRgb(15, 209, 173);
        }

        private void macroBtn_Released(object sender, EventArgs e)
        {
            macroBtn.BackgroundColor = Color.FromRgb(15, 209, 173);
            BMRBtn.BackgroundColor= Color.FromRgb(124, 230, 163);
            caloricBtn.BackgroundColor = Color.FromRgb(124, 230, 163);
        }
    }
}