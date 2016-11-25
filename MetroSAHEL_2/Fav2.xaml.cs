using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class Fav2 : Page
    {
        public Fav2()
        {
            this.InitializeComponent();
        }

        ObservableCollection<Station> StationsList = new ObservableCollection<Station>();
        Station st;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            StationsList = StationManager.getSatationSM();
            favListView.ItemsSource = StationsList;
        }


        private void favListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            st = e.ClickedItem as Station;
             
            AcceptButton.IsEnabled = true;
        }

        private async void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData.Current.RoamingSettings.Values["FirstStationIdSM"] = Convert.ToString(st.Id);
            MessageDialog mbox = new MessageDialog("Les stations sont sauvegardé \nAller à la page d'accueil ");
            await mbox.ShowAsync();
        }

         
    }
}
