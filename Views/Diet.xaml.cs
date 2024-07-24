namespace Calorium.Views;

public partial class Diet : ContentPage
{
	public Diet()
	{
		InitializeComponent();
	}

    private void proteinsBtn_Pressed(object sender, EventArgs e)
    {
        proteinLabel.Text = "Proteins are the molecules that used to repair cells and of course, build muscle. The process which builds the muscles is known as protein synthesis.\n Your daily protein intake should be at around 25% out of the daily total caloric sum.\n You may consume foods that promote a high value in protein, like: chicken, beef, cheese, yogurt, milk, eggs, peanuts, lentils, fish etc.\n";

        proteinLabel.IsVisible = true;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;
        recompositionLabel.IsVisible = false;

        proteinsBtn.BackgroundColor = Colors.LightBlue;
    }
    private void proteinsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightBlue;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        recompositionBtn.BackgroundColor = Colors.LightGreen;
    }

    private void carbsBtn_Pressed(object sender, EventArgs e)
    {
        carbsLabel.Text = "Carbohydrates(fiber, starches and sugars) are used by the human body by transforming them into glucose, resulting energy.\n There are two types of carbohydrates: simple and complex. Simple carbs could be: sodas, sweets, cookies, fast food, white bread etc. While complex carbs are the: fruits, vegetables, whole grains, brown rice etc. Simple carbs are known to be more easily digestible for the body, while the complex carbs are the exact opposite. They take longer to digest because they aren't processed and they are higher in fiber, vitamins and minerals, and fill you up with more energy.\n Simple carbs can be consumed by a person, of course, but in moderation. By any means, you should be aware of the nutritional values they present, which will help you stay on track.\n Carbohydrates should make up around 60% of your daily caloric budget, whether it is for a cut or bulk.";

        proteinLabel.IsVisible = false;
        carbsLabel.IsVisible = true;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;
        recompositionLabel.IsVisible = false;

        carbsBtn.BackgroundColor = Colors.LightBlue;
    }
    private void carbsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightBlue;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        recompositionBtn.BackgroundColor = Colors.LightGreen;
    }

    private void bulkBtn_Pressed(object sender, EventArgs e)
    {
        bulkLabel.Text = "A bulk (a.k.a caloric surplus) is the exact opposite of a cut. You eat more calories than you burn, in order to gain weight. A healthy approach to bulking is when you eat some appropiate and healthy meals.\n Increasing your daily caloric intake by 10% of your maintenance caloric level can definetely help you on the bulking phase.\n Just like for a cut, the maintenance caloric level calculator is going to be useful this time too.";

        proteinLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = true;
        cutLabel.IsVisible = false;
        recompositionLabel.IsVisible = false;

        bulkBtn.BackgroundColor = Colors.LightBlue;
    }

    private void bulkBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightBlue;
        cutBtn.BackgroundColor = Colors.LightGreen;
        recompositionBtn.BackgroundColor = Colors.LightGreen;
    }

    private void fatsBtn_Pressed(object sender, EventArgs e)
    {
        fatsLabel.Text = "Fats are as essential for the human body exactly way the same as fuel is for the car's engine. Fats contribute to a proper nutrition, help the digestive process, build hormones, cells and nerve tissues. On a daily basis, you may follow your diet, of which 15% is fat.";

        proteinLabel.IsVisible = true;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = true;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;
        recompositionLabel.IsVisible = false;

        fatsBtn.BackgroundColor = Colors.LightBlue;
    }

    private void fatsBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightBlue;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        recompositionBtn.BackgroundColor = Colors.LightGreen;
    }

    private void cutBtn_Pressed(object sender, EventArgs e)
    {
        cutLabel.Text = "A cut (a.k.a caloric deficit) means that you consume less calories than you burn, in order to lose weight. A cut is best done when you are reducing your daily calorie intake by 10% of your maintenance caloric level, while getting a healthy amount of protein and fats as well.\n In order to know your actual calorie intake while cutting, start off by calculating your maintenance calories. You should use the maintenance caloric level calculator, in order to observe the amount of calories you need to maintain your weight constant.\n";

        proteinLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = true;
        recompositionLabel.IsVisible = false;


        cutBtn.BackgroundColor = Colors.LightBlue;
    }

    private void cutBtn_Released(Object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        recompositionBtn.BackgroundColor = Colors.LightGreen;
    }

    private void recompositionBtn_Pressed(object sender, EventArgs e)
    {
        recompositionLabel.Text = "Body recomposition represents the process of building muscle while still losing fat.\n Basically, you hop on a diet which consists of your maintenance level of calories, a low amount of fats and high amount of carbs.\n It works best for newbies, people who quit lifting and started all over again, and people who are overweight. Advanced lifters will most likely not benefit the same as these three lifter categories listed earlier, as they are most probably beginners, and their body isn't used to training in the gym, let alone this recomposition approach.\n Also, make sure that you get around eight hours of sleep each night, as rest and sleep in general is something that really helps in losing fat, and not lean mass, during recomposition.\n";
        recompositionBtn.BackgroundColor = Colors.LightBlue;

        recompositionLabel.IsVisible = true;
        proteinLabel.IsVisible = false;
        carbsLabel.IsVisible = false;
        fatsLabel.IsVisible = false;
        bulkLabel.IsVisible = false;
        cutLabel.IsVisible = false;
    }

    private void recompositionBtn_Released(object sender, EventArgs e)
    {
        proteinsBtn.BackgroundColor = Colors.LightGreen;
        carbsBtn.BackgroundColor = Colors.LightGreen;
        fatsBtn.BackgroundColor = Colors.LightGreen;
        bulkBtn.BackgroundColor = Colors.LightGreen;
        cutBtn.BackgroundColor = Colors.LightGreen;
        recompositionBtn.BackgroundColor = Colors.LightBlue;
    }
}