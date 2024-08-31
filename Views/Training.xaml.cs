namespace Calorium.Views;

public partial class Training : ContentPage
{
    private List<(Button button, Label label)> exerciseButtons;
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        this.Opacity = 0;
        await this.FadeTo(1, 1000);
    }
    public Training()
    {
        InitializeComponent();
        InitializeExerciseButtons();
    }

    private void InitializeExerciseButtons()
    {
        exerciseButtons = new List<(Button, Label)>
        {
            (usedBtn, usedLabel),
            (warmupBtn, warmupLabel),
            (restBtn, restTrainingLabel),
            (overloadBtn, overloadLabel),
            (switchingBtn, switchingLabel),
            (failureBtn, failureLabel),
            (heavydutyBtn, heavydutyLabel),
            (junkBtn, junkLabel)
        };
    }
    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var searchText = e.NewTextValue.ToLower();

        foreach (var (button, label) in exerciseButtons)
        {
            button.IsVisible = button.Text.ToLower().Contains(searchText) || label.Text.ToLower().Contains(searchText);
        }
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

    private void ShowLabel(Button button, Label label)
    {
        foreach (var (btn, lbl) in exerciseButtons)
        {
            lbl.IsVisible = false;
            btn.BackgroundColor = Color.FromRgb(124, 230, 163);
        }

        label.IsVisible = true;
        button.BackgroundColor = Color.FromRgb(15, 209, 173);
    }

    private async void usedBtn_Pressed(object sender, EventArgs e)
    {
        usedLabel.Text = "Getting used to the gym may be difficult for a lot of new lifters. Obviously, do not go hard into it from the first day. Take your time for when it comes to mastering your technique and controlling your diet.\nReserve around 60 to 90 minutes for each session, and do high volume workouts for the beginning.";
        ShowLabel(usedBtn, usedLabel);
    }

    private async void restBtn_Pressed(object sender, EventArgs e)
    {
        restTrainingLabel.Text = "While following a high volume schedule in the beginning, opposed to a HIT one where you rest for 4-5 days per week, you may seek around 3 to 4 days of rest per week.\nOn these rest days, you should consistently eat appropiate meals towards your goals, and of course, getting 8-10 hours of sleep per night.\nResting between sets in the gym must allow you go to intensely on another set.\nGetting 2-3 minutes of rest between each set is perfect, and it may help you to maximize your gains as well.\n";
        ShowLabel(restBtn, restTrainingLabel);
    }


    private async void heavydutyBtn_Pressed(object sender, EventArgs e)
    {
        heavydutyLabel.Text = "Designed by famous bodybuilder Mike Mentzer, the Heavy Duty training style consists of short, but extremely intense workouts. Training only twice a week with a maximum of 45 minutes per session, all of your sets should be done until muscular failure sets in.\nYou shouldn't train any body part with more than 2 sets when following this intense training style.\nAlso, slowing down the tempo is something necessary, as it requires more energy to put in.\nRest is the most important part, each rest session's lenght varying between 4-7 days.\n";
        ShowLabel(heavydutyBtn, heavydutyLabel);
    }
    private async void junkBtn_Pressed(object sender, EventArgs e)
    {
        junkLabel.Text = "Overtraining is one of the major gain-killers. Not only it doesn't bring any benefit, but also kills both your gains and testosterone levels, at least temporarily.\nJust consider tracking your number of sets and reps per workout. In general, for any muscle group, you would execute around 10-20 working sets per workout.\nHowever, only your back, glutes and quads will benefit mostly the best from working around 10-20 sets per week, everything else should be fine as long as you work them with 6-8 sets per week.\nUndertraining is, well, exactly the opposite to overtraining.\nIt refers to the idea of not training sufficiently, whether because of too low volume, intensity or frequency. This could mean that you are working sub-optimally, maybe because you're workouts/sets are too easy or infrequent.\n";
        ShowLabel(junkBtn, junkLabel);
    }

    private async void switchingBtn_Pressed(object sender, EventArgs e)
    {
        switchingLabel.Text = "Switching (or rotating) between exercises is something that you want to be focusing on as an intermediate. Being too monotonous is pretty boring, and turns out you won't even benefit too much after doing the same exercises for the same muscle groups each workout.\nFor example, if you are doing dumbbell shoulder presses at each shoulder workout, it would be better to switch over to machine shoulder presses, and don't switch up until a month of doing the same exercise you switched to.\nThis adds some variety to the muscle involved, while shocking it, resulting muscle growth.\n";
        ShowLabel(switchingBtn, switchingLabel);
    }

    private async void failureBtn_Pressed(object sender, EventArgs e)
    {
        failureLabel.Text = "In your first year of training, maybe you've already hit failure a few times on some exercises.\nIn your intermediate years (1-5 years of training), you do not need to go until failure with each set, because it would tire you before you'd actually reach the end of the workout.\nBut, on isolation exercises you may need to take a single set to failure, whether it is the first or last working set. Such isolation exercises are lateral raises, leg extensions, bicep curls etc.\nCompound exercises on the other hand, require 1-3 reps in the tank, which means that you are 1-3 reps away from hitting failure on the certain exercise.\n";
        ShowLabel(failureBtn, failureLabel);
    }

    private async void warmupBtn_Pressed(object sender, EventArgs e)
    {
        warmupLabel.Text = "Warming up is something that you wouldn't want to miss, whether you are a beginner, intermediate or advanced lifter, as it has the capacity to reduce the probability of serious injuries occuring to the joints and muscles.\n Any warm-up exercise must be for the muscle worked at the moment of training.\nDynamic stretching is advised before each workout, while static stretching positions musn't be held for more than 3 seconds.\n";
        ShowLabel(warmupBtn, warmupLabel);
    }

    private async void overloadBtn_Pressed(object sender, EventArgs e)
    {
        overloadLabel.Text = "Progressive overload is something that you need to consider, whether you are a beginner, intermediate or advanced lifter. It consists of adding some weight each workout to your previous records. For example, this week you did a 50kg squat, next week you'll load up to 60kg.\nHowever, most intermediates and advanced level bodybuilders might seek to increase their number of reps completed, rather than the weight lifted.\n";
        ShowLabel(overloadBtn, overloadLabel);
    }
}