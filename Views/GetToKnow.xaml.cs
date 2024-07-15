using Microsoft.Maui.Controls;
using System;
using Calorium.Models;
using System.Collections.ObjectModel;

namespace Calorium.Views;

public partial class GetToKnow : ContentPage
{
    public GetToKnow()
	{
		InitializeComponent();
    }

    private void OnBicepAnimationTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Training));
    }

    private void OnDietAnimationTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Diet));
    }

    private void OnSupplementsAnimationTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Supplements));
    }
}