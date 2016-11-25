using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroSAHEL_2.Models
{
    public class TimeOfStation
    {

        public string StationTime { get; set; }
        public int Id { get; set; }


        public static ObservableCollection<TimeOfStation> ListOfTimeStation(DateTime d, int id, ObservableCollection<Station> ls, ObservableCollection<DateTime> lsdt)
        {
            ObservableCollection<TimeOfStation> tos = new ObservableCollection<TimeOfStation>();
            int i = 1, id1 = id, id2 = id1;
            int s = 1;
            foreach (DateTime x in lsdt)
            {
                if (i == id1)
                {
                    id1 += ls.Count();
                    if (x.Hour != 00)
                    {
                        if (x > d)
                        {
                            if (x.Second == 00)
                                tos.Add(new TimeOfStation { Id = 0, StationTime = x.ToString("HH:mm") });
                            else
                                tos.Add(new TimeOfStation { Id = 0, StationTime = x.ToString("HH:mm") + "  *" });
                            s++;
                        }
                    }
                }
                i++;
            }

            if (tos.Count() == 0)
            {
                i = 1;
                foreach (DateTime x in lsdt)
                {
                    if (i == id2)
                    {
                        id2 += ls.Count();
                        if (x.Hour != 00)
                        {
                            if (x.Second == 00)
                                tos.Add(new TimeOfStation { Id = 0, StationTime = x.ToString("HH:mm") });
                            else
                                tos.Add(new TimeOfStation { Id = 0, StationTime = x.ToString("HH:mm") + "  *" });
                        }
                    }
                    i++;
                }
            }

            return tos;
        }

    }
}
