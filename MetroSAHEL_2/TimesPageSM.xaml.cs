using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MetroSAHEL_2.Models;
using System.Collections.ObjectModel;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MetroSAHEL_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TimesPageSM : Page
    {
        Station s = new Station();
        ObservableCollection<Station> Stations = new ObservableCollection<Station>();
        ObservableCollection<DateTime> TableTime = new ObservableCollection<DateTime>();
        public TimesPageSM()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            DateTime d = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            s = e.Parameter as Station;
            if(s.Direction == Direction.MS)
            {
                Stations = StationManager.getSatationMS();
                TableTime = StationManager.GetRamadanTableTimeMS();
            }
            else if (s.Direction == Direction.SM)
            {
                Stations = StationManager.getSatationSM();
                TableTime = StationManager.GetRamadanTableTimeSM();
            }
            else
            {
                MessageDialog md = new MessageDialog("Something wrong !! \nTry again ");
                await md.ShowAsync();
            }
            NameOfStaionAR.Text = s.StationNameAR;
            StationDesc.Text = s.Desc;
            MyListView.ItemsSource = TimeOfStation.ListOfTimeStation(d, s.Id, Stations,TableTime);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }
    }
}
