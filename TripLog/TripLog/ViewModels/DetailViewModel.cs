using System;
using System.Collections.Generic;
using System.Text;

namespace TripLog.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        private TripLogEntry _entry;
        public DetailViewModel(TripLogEntry entry)
        {
            Entry = entry;
        }
        public TripLogEntry Entry
        {
            get =>  _entry; 
            set {
                _entry = value;
                OnPropertyChanged();
            }
        }


    }
}
