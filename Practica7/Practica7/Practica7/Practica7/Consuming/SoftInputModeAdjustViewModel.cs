using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Practica7.ViewModels
{
	public class SoftInputModeAdjustViewModel : ContentPage
	{
		public SoftInputModeAdjustViewModel()
		{
			Title = "Soft Input Mode Adjust";

			var panButton = new Xamarin.Forms.Button { Text = "Pan" };
			panButton.Clicked += OnPanButtonClicked;
			var resizeButton = new Xamarin.Forms.Button { Text = "Resize " };
			resizeButton.Clicked += OnResizeButtonClicked;

			Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children =
				{
					new StackLayout
					{
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.Center,
						Children = { panButton, resizeButton }
					},
					new Xamarin.Forms.Entry { Placeholder = "Enter text here", 
						VerticalOptions = LayoutOptions.CenterAndExpand }
				}
			};
		}

		void OnPanButtonClicked(object sender, EventArgs e)
		{
			App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Pan);
		}

		void OnResizeButtonClicked(object sender, EventArgs e)
		{
			App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
		}
	}
}
