﻿using Calorium.Views;

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
            Routing.RegisterRoute(nameof(ContactCreator), typeof(ContactCreator));
            Routing.RegisterRoute(nameof(Push_Pull_Legs), typeof(Push_Pull_Legs));
            Routing.RegisterRoute(nameof(ArnoldSplit), typeof(ArnoldSplit));
            Routing.RegisterRoute(nameof(HeavyDuty), typeof(HeavyDuty));
            Routing.RegisterRoute(nameof(BMRImperial), typeof(BMRImperial));
            Routing.RegisterRoute(nameof(BMRMetric), typeof(BMRMetric));
            Routing.RegisterRoute(nameof(QRScanner), typeof(QRScanner));
        }
    }
}
