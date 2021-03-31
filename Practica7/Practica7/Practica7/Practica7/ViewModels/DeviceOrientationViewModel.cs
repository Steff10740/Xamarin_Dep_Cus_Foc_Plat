using Practica7.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Practica7.Models;
namespace Practica7.ViewModels
{
    public class  DeviceOrientationViewModel 
    {
        DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
    }
}
