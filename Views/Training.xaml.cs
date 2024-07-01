namespace Calorium.Views;

public partial class Training : ContentPage
{
	public Training()
	{
		InitializeComponent();
	}

	private void usedBtn_Pressed(object sender, EventArgs e)
    {
        usedLabel.Text = "Getting used may be difficult for a lot of new lifters. Obviously, do not go hard into it from the first day. Take your time for when it comes to mastering your technique and controlling your food. Reserve around 60 to 90 minutes for each session, and do high volume workouts for the beginning. As you progressively lift more, anywhere in between 6-12 months of lifting, you should switch to the Heavy Duty training style, created by Mike Mentzer.";

        usedLabel.IsVisible = true;
        restLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
        overtrainingBtn.IsVisible = false;

        usedBtn.BackgroundColor = Colors.LightBlue;
    }

    private void usedBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightBlue;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        overtrainingBtn.BackgroundColor = Colors.LightGreen;
    }

    private void restBtn_Pressed(object sender, EventArgs e)
    {
        restLabel.Text = "While following a high volume workout in the beginning, you may seek around 3 to 4 days of rest per week. On these rest days, you should consistently eat appropiate meals towards your goals, and of course, getting 8-10 hours of sleep per night.";

        usedLabel.IsVisible = false;
        restLabel.IsVisible = true;
        heavydutyLabel.IsVisible = false;
        overtrainingBtn.IsVisible = false;

        restBtn.BackgroundColor = Colors.LightBlue;
    }

    private void restBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightBlue;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        overtrainingBtn.BackgroundColor = Colors.LightGreen;
    }


    private void heavydutyBtn_Pressed(object sender, EventArgs e)
    {
        heavydutyLabel.Text = "Designed by famous bodybuilder Mike Mentzer, the Heavy Duty training style consists of short, but extremely intense workouts. Training only twice a week with a maximum of 45 minutes per session, all of your sets should be done until muscular failure sets in. You shouldn't train any body part with more than 3 sets when following this intense training style. Also, slowing down the tempo is something necessary, as it requires more energy to put in. Rest is the most important part, each rest session's lenght varying between 4-7 days.";

        usedLabel.IsVisible = false;
        restLabel.IsVisible = false;
        heavydutyLabel.IsVisible = true;
        overtrainingBtn.IsVisible = false;

        heavydutyBtn.BackgroundColor = Colors.LightBlue;
    }

    private void heavydutyBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightBlue;
        overtrainingBtn.BackgroundColor= Colors.LightGreen;
    }

    private void overtrainingBtn_Pressed(object sender, EventArgs e)
    {
        overtrainingLabel.Text = "Overtraining is one of the major gain-killers. Not only it doesn't bring any benefit, but also kills both your gains and testosterone levels, at least temporarily.";
        usedLabel.IsVisible = false;
        restLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
        overtrainingBtn.IsVisible = true;

        overtrainingBtn.BackgroundColor = Colors.LightBlue;
    }

    private void overtrainingBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        overtrainingBtn.BackgroundColor = Colors.LightBlue;
    }
}