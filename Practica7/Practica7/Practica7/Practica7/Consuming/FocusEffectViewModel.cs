using System;
using System.Collections.Generic;
using System.Text;
using Practica7.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica7.ViewModels
{
    public class FocusEffectViewModel : ContentPage
	{
		public FocusEffectViewModel()
		{
			var entry = new Entry
			{
				Text = "Escriba algo...",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				WidthRequest = Device.RuntimePlatform == Device.UWP ? 250 : 220
			};
			entry.Effects.Add(Effect.Resolve("Xamarin.FocusEffect"));

			Content = new StackLayout
			{
				Padding = new Thickness(0, 20, 0, 0),
				Children = {
					new Label {
						Text = "Focus Effect - Hello World",
						FontAttributes = FontAttributes.Bold,
						HorizontalOptions = LayoutOptions.Center,
						BackgroundColor = Color.Aquamarine
					},
					entry
				}
			};
		}
	}
}
