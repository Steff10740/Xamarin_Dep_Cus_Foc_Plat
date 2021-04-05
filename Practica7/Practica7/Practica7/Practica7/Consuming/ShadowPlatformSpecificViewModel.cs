using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Practica7.Effects.MyCompany.Forms.PlatformConfiguration.Android;

namespace Practica7.ViewModels
{
	public class ShadowPlatformSpecificViewModel : ContentPage
	{
		public ShadowPlatformSpecificViewModel()
		{
			var shadowLabel = new Label { Text = "Label Shadow Effect", 
				FontAttributes = FontAttributes.Bold, 
				HorizontalOptions = LayoutOptions.Center, 
				VerticalOptions = LayoutOptions.CenterAndExpand };

			Content = new Grid
			{
				Margin = new Thickness(50),
				Children = {
					new Label { Text = "Effect Exposed by a Platform Specific - Hello World", 
						FontAttributes = FontAttributes.Bold, 
						HorizontalOptions = LayoutOptions.Center },
					shadowLabel
				}
			};

			
			shadowLabel.On<Android>().SetIsShadowed(true);
			
		}
	}
}
