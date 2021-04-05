using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Practica7.Models;
using Practica7.Services;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Practica7
{
    public partial class OrientationPage : ContentPage
    {
        public OrientationPage()
        {
            ///InitializeComponent();
        }

        void OnGetDeviceOrientationButtonClicked(object sender, EventArgs e)
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
           ///orientationLabel.Text = orientation.ToString();
        }

    }
}
