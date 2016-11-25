using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Connectivity;
using Windows.Storage;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MetroSAHEL_2.Models;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MetroSAHEL_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SMPage : Page
    {
        ObservableCollection<Station> Stations = new ObservableCollection<Station>();
        ObservableCollection<DateTime> TableTime = new ObservableCollection<DateTime>();
        string Direction;
        bool v = false;
        DispatcherTimer timer = new DispatcherTimer();
        int nb = 1;
      

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            Direction = e.Parameter.ToString();
            if(Direction == "MS")
            {
                Stations = StationManager.getSatationMS();
                TableTime = StationManager.GetRamadanTableTimeMS();
            }
            else if (Direction == "SM")
            {
                Stations = StationManager.getSatationSM();
                TableTime = StationManager.GetRamadanTableTimeSM();
            }
            else
            {
                MessageDialog md = new MessageDialog("Something wrong !!\n try again ");
                await md.ShowAsync();
                Frame.Navigate(typeof(HomePage));
            }
        }

        public SMPage()
        {
            this.InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
        }

        public static bool IsInternet()
        {
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            bool internet = (connections != null) && (connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);
            return internet;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            if(Direction == "SM")
            {
                if (ApplicationData.Current.RoamingSettings.Values["FirstStationIdSM"] != null)
                {
                    nb = Convert.ToInt32(ApplicationData.Current.RoamingSettings.Values["FirstStationIdSM"].ToString());
                }
            }
            else if(Direction == "MS")
            {
                if (ApplicationData.Current.RoamingSettings.Values["FirstStationIdMS"] != null)
                {
                    nb = Convert.ToInt32(ApplicationData.Current.RoamingSettings.Values["FirstStationIdMS"].ToString());
                }
            }
            
            DateTime d = StationManager.NearStation(DateTime.Now, nb, Stations, TableTime);
            idd.Text = d.ToString("HH:mm");
            Station a1 = StationManager.SearchNameFromId(nb, Stations);
            NameAr.Text = a1.StationNameAR;
            if (d.Second != 0)
                Dim.Text = "*";
            else
                Dim.Text = "";
            timer.Start();
            ListOfTimes();
        }

        private void Cd_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            //Nothing
        }

        private async void Cd_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            bool result = await Launcher.LaunchUriAsync(new Uri("ms-settings:privacy-location"));
        }

        private void Timer_Tick(object sender, object e)
        {
            if (v)
            {
                DateTime d = StationManager.NearStation(DateTime.Now, nb, Stations, TableTime);
                idd.Text = d.ToString("HH:mm");
                ListOfTimes();
                v = false;
            }
            TimeSpan t = StationManager.RestOfTime(StationManager.NearStation(DateTime.Now, nb, Stations, TableTime));
            rest.Text = string.Format("{0}:{1}:{2}", t.Hours.ToString().PadLeft(2, '0'), t.Minutes.ToString().PadLeft(2, '0'), t.Seconds.ToString().PadLeft(2, '0'));// t.Hours + ":" + t.Minutes + ":" + t.Seconds;
            if (t.Hours == 0 && t.Seconds == 0 && t.Minutes == 0)
            {
                v = true;
            }
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {


            textBlock.Visibility = Visibility.Collapsed;
            LocationAnim.Stop();
            var aux = e.ClickedItem as Station;
            Station p = aux;
            nb = p.Id;
            DateTime d = StationManager.NearStation(DateTime.Now, nb, Stations, TableTime);
            idd.Text = d.ToString("HH:mm");
            NameAr.Text = p.StationNameAR;
            if (d.Second != 0)
                Dim.Text = "*";
            else
                Dim.Text = "";
            timer.Start();
            ListOfTimes();
        }

        private void ListOfTimes()
        {
            ObservableCollection<TimeOfStation> tos = new ObservableCollection<TimeOfStation>();
            tos = TimeOfStation.ListOfTimeStation(DateTime.Now, nb, Stations, TableTime);
            MyListView2.ItemsSource = tos;
        }

       

    }
}
