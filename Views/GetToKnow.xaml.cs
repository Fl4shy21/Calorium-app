namespace Calorium.Views;

public partial class GetToKnow : ContentPage
{
	public GetToKnow()
	{
		InitializeComponent();
	}

	private void proteinsBtn_Pressed(object sender, EventArgs e)
    {
        proteinLabel.Text = "Proteins are the molecules that used to repair cells and of course, build muscle. The process which builds the muscles is known as protein synthesis.";

        proteinLabel.IsVisible = true;
        carbsLabel.IsVisible=false;
        fatsLabel.IsVisible=false;
        bulkLabel.IsVisible=false;
        cutLabel.IsVisible=false;
    }
    private void proteinsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightBlue;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }

    private void carbsBtn_Pressed(object sender, EventArgs e)
    {
        carbsLabel.Text = "Carbohydrates(fiber, starches and sugars) are used by the human body by transforming them into glucose, resulting energy.\n There are two types of carbohydrates: simple and complex.Simple carbs could be: sodas, sweets, cookies, fast food, white bread etc. While complex carbs are the: fruits, vegetables, whole grains, brown rice etc. Simple carbs are known to be more easily digestible for the body, the complex carbs are the exact opposite.They take longer to digest because they aren't processed and they are higher in fiber, vitamins and minerals.\n Simple carbs can be consumed by a person, of course, but in moderation. By any means, you should be aware of the nutritional values they present, which will help you stay on track.";

        carbsLabel.IsVisible = true;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        proteinLabel.IsVisible = false;
    }
    private void carbsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightBlue;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }

    private void bulkBtn_Pressed(object sender, EventArgs e)
    {
        bulkLabel.Text = "A bulk (a.k.a caloric surplus) is the exact opposite of a cut. You eat more calories than you burn, in order to gain weight. A healthy approach to bulking is when you eat some lean, healthy meals.\n Increasing your daily caloric intake by 400-500 calories, can definetely help you on the bulking phase.\n Just like for a cut, the maintenance caloric level calculator is going to be useful this time too.";

        bulkLabel.IsVisible = true;
        cutLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        proteinLabel.IsVisible=false;
    }

    private void bulkBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightBlue;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }

    private void fatsBtn_Pressed(object sender, EventArgs e)
    {
        fatsLabel.Text = "Fats for the human body are exactly the same as fuel for the car's engine. Fats are used to build hormones, cells and nerve tissues.";

        fatsLabel.IsVisible = true;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        proteinLabel.IsVisible = false;
    }

    private void fatsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightBlue;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }

    private void cutBtn_Pressed(object sender, EventArgs e)
    {
        cutLabel.Text = "A cut (a.k.a caloric deficit) means that you consume less calories than you burn, in order to lose weight. A cut is best done when you are reducing your daily calorie intake by 400-500 calories, while getting a healthy amount of protein too. In order to know your actual calorie intake while bulking, start off by calculating your maintenance calories. You should use the maintenance caloric level calculator, in order to observe the amount of calories you need to maintain your weight constant. Cutting up to 500 calories per day is going to help you lose weight.";

        cutLabel.IsVisible = true;
        bulkLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        proteinLabel.IsVisible = false;
    }

    private void cutBtn_Released(Object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightBlue;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }

    private void usedBtn_Pressed(object sender, EventArgs e)
    {
        usedLabel.Text = "Getting used may be difficult for a lot of new lifters. Obviously, do not go hard into it from the first day. Take your time for when it comes to mastering your technique and controlling your food. Reserve around 60 to 90 minutes for each session, and do high volume workouts for the beginning. As you progressively lift more, anywhere in between 6-12 months of lifting, you should switch to the Heavy Duty training style, created by Mike Mentzer.";

        usedLabel.IsVisible = true;
        restLabel.IsVisible = false;
        heavydutyLabel.IsVisible = false;
    }

    private void usedBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightBlue;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }

    private void restBtn_Pressed(object sender, EventArgs e)
    {
        restLabel.Text = "While following a high volume workout in the beginning, you may seek around 3 to 4 days of rest per week. On these rest days, you should consistently eat appropiate meals towards your goals, and of course, getting 8-10 hours of sleep per night.";

        restLabel.IsVisible = true;
        usedLabel.IsVisible = false;
        heavydutyLabel.IsVisible=false;
    }

    private void restBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightBlue;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }


    private void heavydutyBtn_Pressed(object sender, EventArgs e)
    {
        heavydutyLabel.Text = "Designed by famous bodybuilder Mike Mentzer, the Heavy Duty training style consists of short, but extremely intense workouts. Training only twice a week with a maximum of 50 minutes per session, all of your sets should be done until muscular failure sets in. You shouldn't train any body part with more than 5 sets when following this intense training style. Also, slowing down the tempo is something necessary, as it requires more energy to put in.";

        heavydutyLabel.IsVisible = true;
        usedLabel.IsVisible = false;
        restLabel.IsVisible = false;
    }

    private void heavydutyBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightBlue;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }

    private void wheyBtn_Pressed(object sender, EventArgs e)
    {
        wheyLabel.Text = "The whey protein is a sport supplement which helps an athlete to ensure his daily proteic goals. While it is not meant to be a replacement for real food, it can be used in moderation with one scoop per day.";

        wheyLabel.IsVisible = true;
        creatineLabel.IsVisible = false;

        wheyBtn.BackgroundColor = Colors.LightBlue;
    }

    private void wheyBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightGreen;
        wheyBtn.BackgroundColor = Colors.LightBlue;
    }

    private void creatineBtn_Pressed(object sender, EventArgs e)
    {
        creatineLabel.Text = "Creatine is probably the most used and known sport supplement of all time. It consists of ATP, which means energy for the body. Creatine can be found in meat, fish, eggs and many more foods, but using creatine in a powdery form is more convenient.";

        creatineLabel.IsVisible = true;
        wheyLabel.IsVisible = false;

        creatineBtn.BackgroundColor = Colors.LightBlue;
    }
    private void creatineBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        usedBtn.BackgroundColor = Colors.LightGreen;
        restBtn.BackgroundColor = Colors.LightGreen;
        heavydutyBtn.BackgroundColor = Colors.LightGreen;
        creatineBtn.BackgroundColor = Colors.LightBlue;
        wheyBtn.BackgroundColor = Colors.LightGreen;
    }
}