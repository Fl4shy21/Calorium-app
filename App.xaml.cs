using Calorium.Views;

namespace Calorium
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OnboardingPage();
        }
    }
}