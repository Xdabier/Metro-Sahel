using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace MetroSAHEL_2.Models
{
    class LocationManager
    {
        public async static Task<Geoposition> getLocation()
        {
            var accessStatus = await Geolocator.RequestAccessAsync();
            if (accessStatus != GeolocationAccessStatus.Allowed)
                return null;
            var geolocator = new Geolocator();
            var position = await geolocator.GetGeopositionAsync();
            return position;
        }

        static decimal DistanceBetween(double latA, double longA, double latB, double longB)
        {
            var RadianLatA = Math.PI * latA / 180;
            var RadianLatb = Math.PI * latB / 180;
            var RadianLongA = Math.PI * longA / 180;
            var RadianLongB = Math.PI * longB / 180;

            double theDistance = (Math.Sin(RadianLatA)) * Math.Sin(RadianLatb) + Math.Cos(RadianLatA) * Math.Cos(RadianLatb) * Math.Cos(RadianLongA - RadianLongB);
            decimal dis = Convert.ToDecimal(((Math.Acos(theDistance) * (180.0 / Math.PI)))) * 69.09M * 1.6093M;
            return dis;
        }

        public static Station NearStationFromPosition(ObservableCollection<Station> listStation, double x, double y)
        {

            Station i = new Station();
            decimal diff;
            i = StationManager.SearchNameFromId(1, listStation);
            diff = DistanceBetween(x, y, i.Lat, i.Long);
            foreach (Station s in listStation)
            {
                decimal diss = DistanceBetween(x, y, s.Lat, s.Long);
                if (diss < diff)
                {
                    i = s;
                    diff = diss;
                }
            }
            return i;
        }

        public async static Task<Station> NearStationFromLocation(ObservableCollection<Station> listStation)
        {
            var pos = await getLocation();
            double x = pos.Coordinate.Latitude, y = pos.Coordinate.Longitude;
            Station i = new Station();
            decimal diff;
            i = StationManager.SearchNameFromId(1, listStation);
            diff = DistanceBetween(x, y, i.Lat, i.Long);
            foreach (Station s in listStation)
            {
                if (DistanceBetween(x, y, s.Lat, s.Long) < diff)
                {
                    i = s;
                    diff = DistanceBetween(x, y, s.Lat, s.Long);
                }
            }

            return i;
        }

    }
}
