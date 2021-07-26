using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripLog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {

        DetailViewModel viewModel => BindingContext as DetailViewModel;
        public DetailPage(TripLogEntry entry)
        {
            InitializeComponent();
            BindingContext = new DetailViewModel(entry);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(viewModel.Entry.Latitude, viewModel.Entry.Longitude), Distance.FromMiles(.5)
                ));
            
            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = viewModel.Entry.Title,
                Position = new Position(viewModel.Entry.Latitude, viewModel.Entry.Longitude)
            });
           
        }
    }
}