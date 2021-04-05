using Practica7.Droid.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Practica7.Effects.MyCompany.Forms.PlatformConfiguration.Android;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(LabelShadowEffectAndroid), "LabelShadowEffectAndroid")]
namespace Practica7.Droid.Services
{
	public class LabelShadowEffectAndroid : PlatformEffect
	{
		protected override void OnAttached()
		{
			UpdateShadow();
		}

		protected override void OnDetached()
		{
		}

		protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(args);

			if (args.PropertyName == ShadowEffect.IsShadowedProperty.PropertyName)
			{
				UpdateShadow();
			}
		}

		void UpdateShadow()
		{
			try
			{
				if (((Label)Element).OnThisPlatform().IsShadowed())
				{
					float radius = 5;
					float distanceX = 5;
					float distanceY = 5;
					Android.Graphics.Color color = Android.Graphics.Color.Black;
					(Control as Android.Widget.TextView).SetShadowLayer(radius, distanceX, distanceY, color);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}
	}
}
