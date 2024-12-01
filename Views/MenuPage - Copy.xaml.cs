using Calorium.Models;
using System.Collections.ObjectModel;

namespace Calorium.Views;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
        InitializeItems();
        BindingContext = this;
    }

    internal ObservableCollection<CollectionItem> CollectionItems { get; set; }

    private void InitializeItems()
    {
        CollectionItems = new ObservableCollection<CollectionItem> 
        { 
            new CollectionItem { Title = "Instagram", Image = "instagram.svg", Link = "https://www.instagram.com/albertus.magnus22/"},
            new CollectionItem { Title = "Discord", Image = "discord.svg", Link = "http://discordapp.com/users/745564638862639215"},
            new CollectionItem { Title = "Fiverr", Image = "fiverr_logo.png", Link = "https://www.fiverr.com/fl4shy_21?up_rollout=true"},
        };
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