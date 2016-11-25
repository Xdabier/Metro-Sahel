using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Connectivity;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MetroSAHEL_2.Models;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MetroSAHEL_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MapPage : Page
    {
        ObservableCollection<Station> ls = new ObservableCollection<Station>();

        double xx;
        double yy;
        bool k;

        public MapPage()
        {
            this.InitializeComponent();
            if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 5)
            {
                MyMap.ColorScheme = MapColorScheme.Dark;
            }
            ls = StationManager.getSatationSM();
            StationListView1.ItemsSource = ls;


        }

        private void SetPoint(double Lat, double Long, string Name)
        {
            // Specify a known location.
            BasicGeoposition snPosition = new BasicGeoposition() { Latitude = Lat, Longitude = Long };
            Geopoint snPoint = new Geopoint(snPosition);

            // Create a MapIcon.
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Location = snPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = Name;

            mapIcon1.ZIndex = 0;

            // Add the MapIcon to the map.
            MyMap.MapElements.Add(mapIcon1);

            // Center the map over the POI.
            MyMap.Center = snPoint;
            MyMap.ZoomLevel = 16;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            setPositionOfStations();
            if (IsInternet())
                setCurrentLocation();
            MyMap.Center = new Geopoint(
            new BasicGeoposition()
            {
                Latitude = 35.670235,
                Longitude = 10.882897
            }
          );
            MyMap.ZoomLevel = 10;
        }

        private async void StationListView1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var st = e.ClickedItem as Station;
            MyMap.Center = new Geopoint(
                new BasicGeoposition()
                {
                    Latitude = st.Lat,
                    Longitude = st.Long
                }
          );
            MapScene mp = MapScene.CreateFromLocationAndRadius(new Geopoint(new BasicGeoposition() { Latitude = st.Lat, Longitude = st.Long }), 400);
            await MyMap.TrySetSceneAsync(mp);
        }

        public void setPositionOfStations()
        {

            foreach (Station x in StationManager.getSatationSM())
            {
                SetPoint(x.Lat, x.Long, x.StationNameFR);
            }
            MyMap.Center = new Geopoint(
            new BasicGeoposition()
            {
                Latitude = 35.670235,
                Longitude = 10.882897
            }
            );
            MyMap.ZoomLevel = 10;
        }

        public async void setCurrentLocation()
        {

            LocaionAnim1.Begin();

            try
            {
                var pos = await LocationManager.getLocation();
                xx = pos.Coordinate.Latitude;
                yy = pos.Coordinate.Longitude;
                BasicGeoposition snPosition = new BasicGeoposition() { Latitude = xx, Longitude = yy };
                Geopoint snPoint = new Geopoint(snPosition);

                // Create a MapIcon.
                MapIcon mapIcon1 = new MapIcon();
                mapIcon1.Location = snPoint;
                mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
                mapIcon1.Image = RandomAccessStreamReference.CreateFromUri(new Uri(@"ms-appx:///Assets\locIcon.png"));
                mapIcon1.ZIndex = 0;

                // Add the MapIcon to the map.
                MyMap.MapElements.Add(mapIcon1);
            }
            catch
            {
                ContentDialog cd = new ContentDialog();
                cd.Title = "Votre paramètre d'emplacement est désactivée ! ";
                cd.Content = "Si vous souhaitez accéder à votre réglage de l'emplacement, cliquez Paramétre, si vous souhaitez annuler cliquez Annuler.";
                cd.PrimaryButtonText = "Paramétre ";
                cd.SecondaryButtonText = "Annuler";
                cd.PrimaryButtonClick += Cd_PrimaryButtonClick;
                cd.SecondaryButtonClick += Cd_SecondaryButtonClick;
                await cd.ShowAsync();
            }
            LocaionAnim1.Stop();

        }

        private void Cd_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private async void Cd_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            bool result = await Launcher.LaunchUriAsync(new Uri("ms-settings:privacy-location"));
            setCurrentLocation();
        }

        public async void direction()
        {
            directionAnim.Begin();
            try
            {

                MyMap.Routes.Clear();
                MyMap.MapElements.Clear();
                setPositionOfStations();
                BasicGeoposition startLocation = new BasicGeoposition();

                startLocation = new BasicGeoposition() { Latitude = xx, Longitude = yy };
                setCurrentLocation();




                Station s = await LocationManager.NearStationFromLocation(StationManager.getSatationSM());
                BasicGeoposition endLocation = new BasicGeoposition() { Latitude = s.Lat, Longitude = s.Long };

                MapRouteFinderResult routeResult =
                      await MapRouteFinder.GetDrivingRouteAsync(
                      new Geopoint(startLocation),
                      new Geopoint(endLocation),
                      MapRouteOptimization.Time,
                      MapRouteRestrictions.None);

                if (routeResult.Status == MapRouteFinderStatus.Success)
                {


                    MapRouteView viewOfRoute = new MapRouteView(routeResult.Route);
                    if (MyMap.ColorScheme == MapColorScheme.Dark)
                        viewOfRoute.RouteColor = Colors.Orange;
                    else
                        viewOfRoute.RouteColor = Colors.DeepSkyBlue;
                    MyMap.Routes.Add(viewOfRoute);
                    await MyMap.TrySetViewBoundsAsync(
                          routeResult.Route.BoundingBox,
                          null,
                          Windows.UI.Xaml.Controls.Maps.MapAnimationKind.None);
                }
                MapScene mp = MapScene.CreateFromLocationAndRadius(new Geopoint(startLocation), 400, 60, 30);
                await MyMap.TrySetSceneAsync(mp);
                k = true;
            }

            catch
            {
                if (k)
                {
                    MessageDialog mbx = new MessageDialog("Réessayer ");
                    await mbx.ShowAsync();
                    k = false;
                }
            }
            directionAnim.Stop();


        }

        private async void GetPositionButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsInternet())
            {
                try
                {
                    MyMap.MapElements.Clear();
                    setPositionOfStations();
                    setCurrentLocation();
                    var MyPosition = await LocationManager.getLocation();
                    MapScene mp = MapScene.CreateFromLocationAndRadius(new Geopoint(new BasicGeoposition() { Latitude = xx, Longitude = yy }), 500);
                    await MyMap.TrySetSceneAsync(mp);
                }
                catch
                {

                }
            }
            else
            {
                MessageDialog mbox = new MessageDialog("Vérifiez votre connexion réseau !");
                await mbox.ShowAsync();

            }
        }

        private async void directionButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsInternet())
            {
                direction();
            }
            else
            {
                MessageDialog mbox = new MessageDialog("Vérifiez votre connexion réseau !");
                await mbox.ShowAsync();
            }

        }

        private void ZoomOutButton_Click(object sender, RoutedEventArgs e)
        {
            MyMap.Center = new Geopoint(
            new BasicGeoposition()
            {
                Latitude = 35.670235,
                Longitude = 10.882897
            }
            );
            MyMap.ZoomLevel = 10;
        }

        private void ClearMapButton_Click(object sender, RoutedEventArgs e)
        {
            MyMap.MapElements.Clear();
            MyMap.Routes.Clear();
            setPositionOfStations();
        }

        public static bool IsInternet()
        {
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            bool internet = (connections != null) && (connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);
            return internet;
        }

        private async void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if (IsInternet())
                MyMap.Style = MapStyle.Aerial3D;
            else
            {
                MessageDialog mbox = new MessageDialog("Vérifiez votre connexion réseau !");
                await mbox.ShowAsync();
            }
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            MyMap.Style = MapStyle.Terrain;
        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            MyMap.Style = MapStyle.Road;
        }
    }
}
