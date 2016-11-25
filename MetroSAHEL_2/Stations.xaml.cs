using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MetroSAHEL_2.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MetroSAHEL_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Stations : Page
    {
        ObservableCollection<Station> listMS = StationManager.getSatationMS();
        ObservableCollection<Station> listSM = StationManager.getSatationSM();

        public Stations()
        {
            this.InitializeComponent();
            MyGridView1.ItemsSource = StationManager.getSatationSM();
            MyGridView2.ItemsSource = StationManager.getSatationMS();
        }


        private async void MyGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(TimesPageSM), e.ClickedItem);
        }

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(MyPivot.SelectedIndex)
            {
                case 0:
                    {
                        MSHeaderItem.Opacity = 0.3;
                        SMHeaderItem.Opacity = 1;
                        break;
                    }
                case 1:
                    {
                        MSHeaderItem.Opacity = 1;
                        SMHeaderItem.Opacity = 0.3;
                        break;
                    }
                default:break;
            }
        }
    }
}
