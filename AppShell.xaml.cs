using Calorium.Views;

namespace Calorium
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
            Routing.RegisterRoute(nameof(MaintenanceLevelCalculator), typeof(MaintenanceLevelCalculator));
            Routing.RegisterRoute(nameof(GetToKnow), typeof(GetToKnow));
            Routing.RegisterRoute(nameof(ChooseYourPlan), typeof(ChooseYourPlan));
            Routing.RegisterRoute(nameof(ChooseYourPlan_Beginner), typeof(ChooseYourPlan_Beginner));
            Routing.RegisterRoute(nameof(ChooseYourPlan_Advanced), typeof(ChooseYourPlan_Advanced));
            Routing.RegisterRoute(nameof(ContactCreator), typeof(ContactCreator));
            Routing.RegisterRoute(nameof(HeavyDuty), typeof(HeavyDuty));
            Routing.RegisterRoute(nameof(QRScanner), typeof(QRScanner));
            Routing.RegisterRoute(nameof(ArnoldSplit_Beginner), typeof(ArnoldSplit_Beginner));
            Routing.RegisterRoute(nameof(ArnoldSplit_Advanced), typeof(ArnoldSplit_Advanced));
            Routing.RegisterRoute(nameof(Push_Pull_Legs_Beginner), typeof(Push_Pull_Legs_Beginner));
            Routing.RegisterRoute(nameof(Push_Pull_Legs_Advanced), typeof(Push_Pull_Legs_Advanced));
            Routing.RegisterRoute(nameof(BroSplit), typeof(BroSplit));
            Routing.RegisterRoute(nameof(Diet), typeof(Diet));
            Routing.RegisterRoute(nameof(Training), typeof(Training));
            Routing.RegisterRoute(nameof(Supplements), typeof(Supplements));
            Routing.RegisterRoute(nameof(OnboardingPage), typeof(OnboardingPage));
        }
    }
}
