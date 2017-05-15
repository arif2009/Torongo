using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Torongo.Repository
{
    enum WeatherStatus : int
    {
        Foggy = 1,
        Rainy = 2,
        Sunny,
        Clear
    };
}