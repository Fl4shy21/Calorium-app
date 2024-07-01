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

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Diet));
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Training));
    }

    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Supplements));
    }
}