using Microsoft.Maui.Controls;

namespace Calorium.Views
{
    public partial class Supplements : ContentPage
    {
        private List<(Button button, Label label)> supplementButtons;

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            this.Opacity = 0;
            await this.FadeTo(1, 1000);
        }
        public Supplements()
        {
            InitializeComponent();
            InitializeSupplementButtons();
        }

        private void InitializeSupplementButtons()
        {
            supplementButtons = new List<(Button, Label)>
        {
            (wheyBtn, wheyLabel),
            (creatineBtn, creatineLabel),
            (bcaaBtn, BCAAlabel),
            (fishoilBtn, fishoilLabel),
            (vitaminsBtn, vitaminsLabel)
        };
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
            foreach (var (btn, lbl) in supplementButtons)
            {
                lbl.IsVisible = false;
                btn.BackgroundColor = Color.FromRgb(124, 230, 163);
            }

            label.IsVisible = true;
            button.BackgroundColor = Color.FromRgb(15, 209, 173);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = e.NewTextValue.ToLower();

            foreach (var (button, label) in supplementButtons)
            {
                button.IsVisible = button.Text.ToLower().Contains(searchText) || label.Text.ToLower().Contains(searchText);
            }
        }

        private void wheyBtn_Pressed(object sender, EventArgs e)
        {
            wheyLabel.Text = "The whey protein is a sport supplement which helps an athlete to ensure his daily proteic goals.\nWhile it is not meant to be a replacement for real food, it can be used in moderation with one scoop per day (about 25g of protein/scoop).\n";
            ShowLabel(wheyBtn, wheyLabel);
        }

        private async void creatineBtn_Pressed(object sender, EventArgs e)
        {
            creatineLabel.Text = "Creatine is probably the most used and known sport supplement of all time.\nIt consists of ATP, which means energy for the body.\nCreatine can be found in meat, fish, eggs and many more foods, but using creatine in a powdery form is more convenient.\n";
            ShowLabel(creatineBtn, creatineLabel);
        }

        private async void vitaminsBtn_Pressed(object sender, EventArgs e)
        {
            vitaminsLabel.Text = "Vitamins are an essential supplement for your diet, making your immune system, joints and overall bones stronger and producing essential hormones like testosterone.\nAlthough they are available in the form of some pills, they cannot replace the natural vitamins that you take from your diet itself.\n";
            ShowLabel(vitaminsBtn, vitaminsLabel);
        }

        private async void bcaaBtn_Pressed(object sender, EventArgs e)
        {
            BCAAlabel.Text = "BCAAs bring some essential aminoacids into play. They aren't necessary, but in case you have low levels of energy or your muscles become easily fatigued, they sure do help, even though fixes for these issues can be provided from a healthy, well structured diet.\n";
            ShowLabel(bcaaBtn, BCAAlabel);
        }

        private async void fishoilBtn_Pressed(object sender, EventArgs e)
        {
            fishoilLabel.Text = "Fish oil is an excellent choice when it comes to fatty acids, like Omega-3.\nThey improve blood circulation, joint health, focus, memory and overall immunity.\n";
            ShowLabel(fishoilBtn, fishoilLabel);
        }
    }
}

