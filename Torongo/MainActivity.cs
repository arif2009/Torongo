using System;
using System.Collections;
using Android.App;
using Android.Content.PM;
using Android.Widget;
using Android.OS;
using Torongo.Model;
using Torongo.Repository;
using static System.StringComparison;

namespace Torongo
{
    [Activity(Label = "তরঙ্গ", MainLauncher = true, ScreenOrientation= ScreenOrientation.Portrait, Icon = "@drawable/appicon_white")]
    public class MainActivity : Activity
    {
        private Spinner _timeTo;
        private Spinner _timeFrom;
        private Spinner _weather;
        private Spinner _district;
        private Button _find;
        private GridView _gridView;
        private ArrayList _gridViewItems;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            FindAndInitializeControls();

            HandleEvents();

            //_timeTo.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(timeTo_ItemSelected);
        }

        private void FindAndInitializeControls()
        {
            _timeTo = FindViewById<Spinner>(Resource.Id.spnrTimeTo);
            _timeFrom = FindViewById<Spinner>(Resource.Id.spnrTimeFrom);
            _weather = FindViewById<Spinner>(Resource.Id.spnrWeather);
            _district = FindViewById<Spinner>(Resource.Id.spnrDistrict);
            _find = FindViewById<Button>(Resource.Id.btnFind);
            _gridView = FindViewById<GridView>(Resource.Id.gvFrequency);

            //Getting time List
            var timeAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.time_array, Android.Resource.Layout.SimpleSpinnerItem);
            timeAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

            _timeTo.Adapter = timeAdapter;
            _timeFrom.Adapter = timeAdapter;

            //Getting _weather List
            var weatherAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.weather_array, Android.Resource.Layout.SimpleSpinnerItem);
            weatherAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            _weather.Adapter = weatherAdapter;

            //Getting District List
            var districtAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.district_array, Android.Resource.Layout.SimpleSpinnerItem);
            districtAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            _district.Adapter = districtAdapter;
        }

        private void HandleEvents()
        {
            _find.Click += Find_Click;
            _gridView.ItemClick += _gridView_ItemClick;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            var defaultTime = "Choose time";
            var defaultWeather = "Choose weather";
            var defaultDistrict = "Choose district";

            var isDefaultTimeTo = string.Equals(_timeTo.SelectedItem.ToString(), defaultTime, OrdinalIgnoreCase);
            var isDefaultTimeFrom = string.Equals(_timeFrom.SelectedItem.ToString(), defaultTime, OrdinalIgnoreCase);
            var isDefaultWeather = string.Equals(_weather.SelectedItem.ToString(), defaultWeather, OrdinalIgnoreCase);
            var isDefaultDistrict = string.Equals(_district.SelectedItem.ToString(), defaultDistrict, OrdinalIgnoreCase);

            if (isDefaultTimeTo && isDefaultTimeFrom && isDefaultWeather && isDefaultDistrict)
            {
                Toast.MakeText(this, "Select minimum one criteria", ToastLength.Short).Show();
                _gridView.Adapter = null;
                return;
            }

            var to = isDefaultTimeTo ? string.Empty : _timeTo.SelectedItem.ToString();
            var from = isDefaultTimeFrom ? string.Empty : _timeFrom.SelectedItem.ToString();
            var weather = isDefaultWeather ? string.Empty : _weather.SelectedItem.ToString();
            var location = isDefaultDistrict ? string.Empty : _district.SelectedItem.ToString();

            var freqRepo = new FrequencyRepository();

            var criterya = new FrequencyGroup
            {
                To = to,
                From = from,
                Weather = weather,
                Location = location
            };

            try
            {
                var frequency = freqRepo.GetFrequencyByCriterya(criterya);

                if (frequency.Count > 0)
                {
                    _gridViewItems = new ArrayList(frequency);

                    ArrayAdapter adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, _gridViewItems);

                    _gridView.Adapter = adapter;
                }
                else
                {
                    resetGridAndPopulateMsg();
                }
            }
            catch
            {
                resetGridAndPopulateMsg();
            }
        }


        private void _gridView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var msg = new AlertDialog.Builder(this);
            msg.SetNegativeButton("OK", (senderAlert, args) => {
                    // write your own set of instructions
                })
            .SetMessage(_gridViewItems[e.Position].ToString())
            .SetTitle("Frequency")
            .Show();
        }

        private void resetGridAndPopulateMsg()
        {
            _gridView.Adapter = null;
            Toast.MakeText(this, "No frequency found", ToastLength.Short).Show();
        }

        /*private void timeTo_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = (Spinner)sender;
            string toast = string.Format("Selected car is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }*/
    }
}

