using Microsoft.Maui.Controls;

namespace Calorium.Views
{
    public partial class Supplements : ContentPage
    {
        public Supplements()
        {
            InitializeComponent();
        }

        private void wheyBtn_Pressed(object sender, EventArgs e)
        {
            wheyLabel.Text = "The whey protein is a sport supplement which helps an athlete to ensure his daily proteic goals.\nWhile it is not meant to be a replacement for real food, it can be used in moderation with one scoop per day (about 25g of protein/scoop).\n";
            wheyLabel.Opacity = 0;

            creatineLabel.IsVisible = false;
            wheyLabel.IsVisible = true;
            vitaminsLabel.IsVisible = false;
            BCAAlabel.IsVisible = false;
            fishoilLabel.IsVisible = false;

            wheyBtn.BackgroundColor = Colors.LightBlue;
            wheyLabel.FadeTo(1, 500);
        }

        private void wheyBtn_Released(object sender, EventArgs e)
        {
            creatineBtn.BackgroundColor = Colors.LightGreen;
            wheyBtn.BackgroundColor = Colors.LightBlue;
            vitaminsBtn.BackgroundColor = Colors.LightGreen;
            bcaaBtn.BackgroundColor = Colors.LightGreen;
            fishoilBtn.BackgroundColor = Colors.LightGreen;
        }

        private async void creatineBtn_Pressed(object sender, EventArgs e)
        {
            creatineLabel.Text = "Creatine is probably the most used and known sport supplement of all time.\nIt consists of ATP, which means energy for the body.\nCreatine can be found in meat, fish, eggs and many more foods, but using creatine in a powdery form is more convenient.\n";
            creatineLabel.Opacity = 0;

            creatineLabel.IsVisible = true;
            wheyLabel.IsVisible = false;
            vitaminsLabel.IsVisible = false;
            BCAAlabel.IsVisible = false;
            fishoilLabel.IsVisible = false;

            creatineBtn.BackgroundColor = Colors.LightBlue;
            await creatineLabel.FadeTo(1, 500);
        }
        private void creatineBtn_Released(object sender, EventArgs e)
        {
            creatineBtn.BackgroundColor = Colors.LightBlue;
            wheyBtn.BackgroundColor = Colors.LightGreen;
            vitaminsBtn.BackgroundColor = Colors.LightGreen;
            bcaaBtn.BackgroundColor = Colors.LightGreen;
            fishoilBtn.BackgroundColor = Colors.LightGreen;
        }

        private async void vitaminsBtn_Pressed(object sender, EventArgs e)
        {
            vitaminsLabel.Text = "Vitamins are an essential supplement for your diet, making your immune system, joints and overall bones stronger and producing essential hormones like testosterone.\nAlthough they are available in the form of some pills, they cannot replace the natural vitamins that you take from your diet itself.\n";
            vitaminsLabel.Opacity = 0;

            creatineLabel.IsVisible = false;
            wheyLabel.IsVisible = false;
            vitaminsLabel.IsVisible = true;
            BCAAlabel.IsVisible = false;
            fishoilLabel.IsVisible = false;

            vitaminsBtn.BackgroundColor = Colors.LightBlue;
            await vitaminsLabel.FadeTo(1, 500);
        }

        private void vitaminsBtn_Released(object sender, EventArgs e)
        {
            wheyBtn.BackgroundColor = Colors.LightGreen;
            creatineBtn.BackgroundColor = Colors.LightGreen;
            vitaminsBtn.BackgroundColor = Colors.LightBlue;
            bcaaBtn.BackgroundColor = Colors.LightGreen;
            fishoilBtn.BackgroundColor = Colors.LightGreen;
        }

        private async void bcaaBtn_Pressed(object sender, EventArgs e)
        {
            BCAAlabel.Text = "BCAAs bring some essential aminoacids into play. They aren't necessary, but in case you have low levels of energy or your muscles become easily fatigued, they sure do help, even though fixes for these issues can be provided from a healthy, well structured diet.\n";
            BCAAlabel.Opacity = 0;

            creatineLabel.IsVisible = false;
            wheyLabel.IsVisible = false;
            vitaminsLabel.IsVisible = false;
            BCAAlabel.IsVisible = true;
            fishoilLabel.IsVisible = false;

            bcaaBtn.BackgroundColor = Colors.LightBlue;
            await BCAAlabel.FadeTo(1, 500);
        }

        private void bcaaBtn_Released(object sender, EventArgs e)
        {
            creatineBtn.BackgroundColor = Colors.LightGreen;
            wheyBtn.BackgroundColor = Colors.LightGreen;
            vitaminsBtn.BackgroundColor = Colors.LightGreen;
            bcaaBtn.BackgroundColor = Colors.LightBlue;
            fishoilBtn.BackgroundColor = Colors.LightGreen;
        }

        private async void fishoilBtn_Pressed(object sender, EventArgs e)
        {
            fishoilLabel.Text = "Fish oil is an excellent choice when it comes to fatty acids, like Omega-3.\nThey improve blood circulation, joint health, focus, memory and overall immunity.\n";
            fishoilLabel.Opacity = 0;

            creatineLabel.IsVisible = false;
            wheyLabel.IsVisible = false;
            vitaminsLabel.IsVisible = false;
            BCAAlabel.IsVisible = false;
            fishoilLabel.IsVisible = true;

            await fishoilLabel.FadeTo(1, 500);
            fishoilBtn.BackgroundColor = Colors.LightBlue;
        }

        private void fishoilBtn_Released(object sender, EventArgs e)
        {
            creatineBtn.BackgroundColor = Colors.LightGreen;
            wheyBtn.BackgroundColor = Colors.LightGreen;
            vitaminsBtn.BackgroundColor = Colors.LightGreen;
            bcaaBtn.BackgroundColor = Colors.LightGreen;
            fishoilBtn.BackgroundColor = Colors.LightBlue;
        }
    }
}

