using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var items = new List<TripLogEntry>{
                new TripLogEntry
                {
                    Title = "Washington Monument",
                    Notes = "Amazing",
                    Rating = 4,
                    Date = new DateTime(2019,02,05),
                    Latitude = 38.8895,
                    Longitude = -77.0352
                },
                 new TripLogEntry
                {
                    Title = "Statue Of Liberty",
                    Notes = "Inspiring",
                    Rating = 5,
                    Date = new DateTime(2019,04,13),
                    Latitude = 40.6892,
                    Longitude = -74.0444
                },
                         new TripLogEntry
                {
                    Title = "Golden Gate Bridge",
                    Notes = "Foggy, but beuty",
                    Rating = 3,
                    Date = new DateTime(2021,05,18),
                    Latitude = 37.8268,
                    Longitude = -122.4798
                },
            };
            trips.ItemsSource = items;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEntryPage());
        }

        private void trips_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var trip = (TripLogEntry)e.CurrentSelection.FirstOrDefault();
            if(trip != null)
            {
                Navigation.PushAsync(new DetailPage(trip));
            }
            trips.SelectedItem = null;
        }
    }
}