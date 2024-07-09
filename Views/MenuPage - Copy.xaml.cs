namespace Calorium.Views;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer1_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(QRScanner));
    }

    private void TapGestureRecognizer2_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ContactCreator));
    }
}