namespace Calorium.Views;

public partial class Training : ContentPage
{
	public Training()
	{
		InitializeComponent();
	}

	private void usedBtn_Pressed(object sender, EventArgs e)
    {
        usedLabel.Text = "Getting used to the gym may be difficult for a lot of new lifters. Obviously, do not go hard into it from the first day. Take your time for when it comes to mastering your technique and controlling your diet. Reserve around 60 to 90 minutes for each session, and do high volume workouts for the beginning.";

        usedLabel.IsVisible = true;
        restTrainingLabel.IsVisible = false;
        restSetsLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
        junkLabel.IsVisible = false;
        switchingLabel.IsVisible = false;  
        failureLabel.IsVisible = false;
        warmupLabel.IsVisible = false;
        overloadLabel.IsVisible = false;

        usedBtn.BackgroundColor = Colors.LightBlue;
    }

    private void usedBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightBlue;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        junkBtn.BackgroundColor = Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightGreen;
        failureBtn.BackgroundColor = Colors.LightGreen;
        warmupBtn.BackgroundColor = Colors.LightGreen;
        overloadBtn.BackgroundColor = Colors.LightGreen;
    }

    private void restBtn_Pressed(object sender, EventArgs e)
    {
        restTrainingLabel.Text = "While following a high volume schedule in the beginning, opposed to a HIT one where you rest for 4-5 days per week, you may seek around 3 to 4 days of rest per week.\n On these rest days, you should consistently eat appropiate meals towards your goals, and of course, getting 8-10 hours of sleep per night.\n";
        restSetsLabel.Text = "Resting between sets in the gym must allow you go to intensely on another set.\n Getting 2-3 minutes of rest between each set is perfect, and it may help you to maximize your gains as well.\n";

        usedLabel.IsVisible = false;
        restTrainingLabel.IsVisible = true;
        restSetsLabel.IsVisible = true;
        heavydutyLabel.IsVisible = false;
        junkLabel.IsVisible = false;
        switchingLabel.IsVisible = false;
        failureLabel.IsVisible = false;
        warmupLabel.IsVisible = false;
        overloadLabel.IsVisible = false;

        restBtn.BackgroundColor = Colors.LightBlue;
    }

    private void restBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightBlue;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        junkBtn.BackgroundColor = Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightGreen;
        failureBtn.BackgroundColor = Colors.LightGreen;
        warmupBtn.BackgroundColor = Colors.LightGreen;
        overloadBtn.BackgroundColor = Colors.LightGreen;
    }


    private void heavydutyBtn_Pressed(object sender, EventArgs e)
    {
        heavydutyLabel.Text = "Designed by famous bodybuilder Mike Mentzer, the Heavy Duty training style consists of short, but extremely intense workouts. Training only twice a week with a maximum of 45 minutes per session, all of your sets should be done until muscular failure sets in. You shouldn't train any body part with more than 3 sets when following this intense training style. Also, slowing down the tempo is something necessary, as it requires more energy to put in. Rest is the most important part, each rest session's lenght varying between 4-7 days.";

        usedLabel.IsVisible = false;
        restTrainingLabel.IsVisible = false;
        restSetsLabel.IsVisible = false;    
        heavydutyLabel.IsVisible = true;
        junkLabel.IsVisible = false;
        switchingLabel.IsVisible = false;
        failureLabel.IsVisible = false;
        warmupLabel.IsVisible = false;
        overloadLabel.IsVisible = false;

        heavydutyBtn.BackgroundColor = Colors.LightBlue;
    }

    private void heavydutyBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightBlue;
        junkBtn.BackgroundColor= Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightGreen;
        failureBtn.BackgroundColor = Colors.LightGreen;
        warmupBtn.BackgroundColor = Colors.LightGreen;
        overloadBtn.BackgroundColor = Colors.LightGreen;
    }

    private void junkBtn_Pressed(object sender, EventArgs e)
    {
        junkLabel.Text = "Overtraining is one of the major gain-killers. Not only it doesn't bring any benefit, but also kills both your gains and testosterone levels, at least temporarily.\n Just consider tracking your number of sets and reps per workout. In general, for any muscle group, you would execute around 10-20 working sets per workout. However, only your back, glutes and quads will benefit mostly the best from working around 10-20 sets per week, everything else should be fine as long as you work them with 6-8 sets per week.\n Undertraining is, well, exactly the opposite to overtraining.\n It refers to the idea of not training sufficiently, whether because of too low volume, intensity or frequency. This could mean that you are working sub-optimally, maybe because you're workouts/sets are too easy or infrequent.\n";
        usedLabel.IsVisible = false;
        restTrainingLabel.IsVisible = false;
        restSetsLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
        junkLabel.IsVisible = true;
        switchingLabel.IsVisible = false;
        failureLabel.IsVisible = false;
        warmupLabel.IsVisible = false;
        overloadLabel.IsVisible = false;

        junkBtn.BackgroundColor = Colors.LightBlue;
    }

    private void junkBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightGreen;
        junkBtn.BackgroundColor = Colors.LightBlue;
        failureBtn.BackgroundColor = Colors.LightGreen;
        warmupBtn.BackgroundColor = Colors.LightGreen;
        overloadBtn.BackgroundColor = Colors.LightGreen;
    }

    private void switchingBtn_Pressed(object sender, EventArgs e)
    {
        switchingLabel.Text = "Switching (or rotating) between exercises is something that you want to be focusing on as an intermediate. Being too monotonous is pretty boring, and turns out you won't even benefit too much after doing the same exercises for the same muscle groups each workout.\n For example, if you are doing dumbbell shoulder presses at each shoulder workout, it would be better to switch over to machine shoulder presses, and don't switch up until a month of doing the same exercise you switched to.\n This adds some variety to the muscle involved, while shocking it, resulting muscle growth.\n";
        switchingLabel.IsVisible = true;
        usedLabel.IsVisible= false;
        restTrainingLabel.IsVisible= false;
        restSetsLabel.IsVisible= false;
        heavydutyLabel.IsVisible= false;
        junkLabel.IsVisible = false;
        failureLabel.IsVisible= false;
        warmupLabel.IsVisible = false;
        overloadLabel.IsVisible = false;

        switchingBtn.BackgroundColor = Colors.LightBlue;
    }

    private void switchingBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        junkBtn.BackgroundColor = Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightBlue;
        failureBtn.BackgroundColor = Colors.LightGreen;
        warmupBtn.BackgroundColor = Colors.LightGreen;
        overloadBtn.BackgroundColor = Colors.LightGreen;
    }

    private void failureBtn_Pressed(object sender, EventArgs e)
    {
        failureLabel.Text = "In your first year of training, maybe you've already hit failure a few times on some exercises.\n In your intermediate years (1-5 years of training), you do not need to go until failure with each set, because it would tire you before you'd actually reach the end of the workout.\n But, on isolation exercises you may need to take a single set to failure, whether it is the first or last working set. Such isolation exercises are lateral raises, leg extensions, bicep curls etc.\n Compound exercises on the other hand, require 1-3 reps in the tank, which means that you are 1-3 reps away from hitting failure on the certain exercise.\n";
        failureLabel.IsVisible = true;
        usedLabel.IsVisible = false;
        restTrainingLabel.IsVisible = false;
        restSetsLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
        junkLabel.IsVisible = false;
        switchingLabel.IsVisible = false;
        warmupLabel.IsVisible = false;
        overloadLabel.IsVisible = false;

        failureBtn.BackgroundColor = Colors.LightBlue;
    }

    private void failureBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        junkBtn.BackgroundColor = Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightGreen;
        failureBtn.BackgroundColor = Colors.LightBlue;
        warmupBtn.BackgroundColor = Colors.LightGreen;
        overloadBtn.BackgroundColor = Colors.LightGreen;
    }

    private void warmupBtn_Pressed(object sender, EventArgs e)
    {
        warmupLabel.Text = "Warming up is something that you wouldn't want to miss, whether you are a beginner, intermediate or advanced lifter, as it has the capacity to reduce the probability of serious injuries occuring to the joints and muscles.\n Any warm-up exercise must be for the muscle worked at the moment of training.\n Dynamic stretching is advised before each workout, while static stretching positions musn't be held for more than 3 seconds.\n";
        warmupBtn.BackgroundColor = Colors.LightBlue;

        warmupLabel.IsVisible = true;
        failureLabel.IsVisible = true;
        usedLabel.IsVisible = false;
        restTrainingLabel.IsVisible = false;
        restSetsLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
        junkLabel.IsVisible = false;
        switchingLabel.IsVisible = false;
        overloadLabel.IsVisible = false;
    }

    private void warmupBtn_Released(object sender, EventArgs e)
    {
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        junkBtn.BackgroundColor = Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightGreen;
        failureBtn.BackgroundColor = Colors.LightGreen;
        warmupBtn.BackgroundColor = Colors.LightBlue;
    }

    private void overloadBtn_Pressed(object sender, EventArgs e)
    {
        overloadLabel.Text = "Progressive overload is something that you need to consider, whether you are a beginner, intermediate or advanced lifter. It consists of adding some weight each workout to your previous records. For example, this week you did a 50kg squat, next week you'll load up to 60kg. However, most intermediates and advanced level bodybuilders might seek to increase their number of reps completed, rather than the weight lifted.";
        overloadLabel.IsVisible = true;

        warmupLabel.IsVisible = false;
        failureLabel.IsVisible = true;
        usedLabel.IsVisible = false;
        restTrainingLabel.IsVisible = false;
        restSetsLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
        junkLabel.IsVisible = false;
        switchingLabel.IsVisible = false;

        overloadBtn.BackgroundColor = Colors.LightBlue;
    }

    private void overloadBtn_Released(object sender, EventArgs e)
    {
        overloadBtn.BackgroundColor = Colors.LightBlue;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        junkBtn.BackgroundColor = Colors.LightGreen;
        switchingBtn.BackgroundColor = Colors.LightGreen;
        failureBtn.BackgroundColor = Colors.LightGreen;
        warmupBtn.BackgroundColor = Colors.LightGreen;

    }
}