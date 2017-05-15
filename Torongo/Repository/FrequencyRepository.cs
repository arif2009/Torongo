using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Torongo.Model;

namespace Torongo.Repository
{
    public class FrequencyRepository
    {
        public List<FrequencyGroup> GetAllFrequencyGroup()
        {
            return _frequencyGroups;
        }

        private static List<FrequencyGroup> _frequencyGroups = new List<FrequencyGroup>()
        {
            new FrequencyGroup()
            {
                To = "0600",
                From = "0700",
                Weather = WeatherStatus.Clear.ToString(),
                Location = "Dhaka",
                Frequencies = new List<long>() { 4422, 4450, 4510, 4650, 4550, 5510, 5650, 5757, 4552, 4425 }
            }
        }; 
    }
}