using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TripLog.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<TripLogEntry> _logEntries;

        public MainViewModel()
        {
            _logEntries = new ObservableCollection<TripLogEntry>
            {
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
        }
        
        public ObservableCollection<TripLogEntry> LogEntries
        {
            get => _logEntries;
            set 
            { 
                _logEntries = value;
                OnPropertyChanged();
            
            }
        }

    }
}
