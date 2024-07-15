namespace Calorium.Views;

public partial class Diet : ContentPage
{
	public Diet()
	{
		InitializeComponent();
	}

    private void proteinsBtn_Pressed(object sender, EventArgs e)
    {
        proteinLabel.Text = "Proteins are the molecules that used to repair cells and of course, build muscle. The process which builds the muscles is known as protein synthesis.";

        proteinLabel.IsVisible = true;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;

        proteinsBtn.BackgroundColor = Colors.LightBlue;
    }
    private void proteinsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightBlue;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
    }

    private void carbsBtn_Pressed(object sender, EventArgs e)
    {
        carbsLabel.Text = "Carbohydrates(fiber, starches and sugars) are used by the human body by transforming them into glucose, resulting energy.\n There are two types of carbohydrates: simple and complex.Simple carbs could be: sodas, sweets, cookies, fast food, white bread etc. While complex carbs are the: fruits, vegetables, whole grains, brown rice etc. Simple carbs are known to be more easily digestible for the body, the complex carbs are the exact opposite.They take longer to digest because they aren't processed and they are higher in fiber, vitamins and minerals.\n Simple carbs can be consumed by a person, of course, but in moderation. By any means, you should be aware of the nutritional values they present, which will help you stay on track.";

        proteinLabel.IsVisible = false;
        carbsLabel.IsVisible = true;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;

        carbsBtn.BackgroundColor = Colors.LightBlue;
    }
    private void carbsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightBlue;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
    }

    private void bulkBtn_Pressed(object sender, EventArgs e)
    {
        bulkLabel.Text = "A bulk (a.k.a caloric surplus) is the exact opposite of a cut. You eat more calories than you burn, in order to gain weight. A healthy approach to bulking is when you eat some lean, healthy meals.\n Increasing your daily caloric intake by 400-500 calories, can definetely help you on the bulking phase.\n Just like for a cut, the maintenance caloric level calculator is going to be useful this time too.";

        proteinLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = true;
        cutLabel.IsVisible = false;

        bulkBtn.BackgroundColor = Colors.LightBlue;
    }

    private void bulkBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightBlue;
        cutBtn.BackgroundColor = Colors.LightGreen;
    }

    private void fatsBtn_Pressed(object sender, EventArgs e)
    {
        fatsLabel.Text = "Fats for the human body are exactly the same as fuel for the car's engine. Fats are used to build hormones, cells and nerve tissues.";

        proteinLabel.IsVisible = true;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = true;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;

        fatsBtn.BackgroundColor = Colors.LightBlue;
    }

    private void fatsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightBlue;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
    }

    private void cutBtn_Pressed(object sender, EventArgs e)
    {
        cutLabel.Text = "A cut (a.k.a caloric deficit) means that you consume less calories than you burn, in order to lose weight. A cut is best done when you are reducing your daily calorie intake by 400-500 calories, while getting a healthy amount of protein too. In order to know your actual calorie intake while bulking, start off by calculating your maintenance calories. You should use the maintenance caloric level calculator, in order to observe the amount of calories you need to maintain your weight constant. Cutting up to 500 calories per day is going to help you lose weight.";

        proteinLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = true;


        cutBtn.BackgroundColor = Colors.LightBlue;
    }

    private void cutBtn_Released(Object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightBlue;
    }
}