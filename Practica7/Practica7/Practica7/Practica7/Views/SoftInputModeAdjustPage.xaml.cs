using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Practica7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SoftInputModeAdjustPage : ContentPage
    {
        public SoftInputModeAdjustPage()
        {
            InitializeComponent();
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