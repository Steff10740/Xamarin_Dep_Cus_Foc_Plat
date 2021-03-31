using Practica7.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Practica7.Services
{
   public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();

    }
}
