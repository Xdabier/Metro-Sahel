using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MetroSAHEL_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        #region BackNavigation
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            myFrame1.Navigate(typeof(HomePage));
            DateNowTextBlock.Text = DateTime.Now.ToString("dddd, MMM dd yyyy ");

            SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;

            myFrame1.Navigated += (s, a) =>
            {
                if (myFrame1.CanGoBack)
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
                }
                else
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
                }
            };
        }

        public event EventHandler<BackRequestedEventArgs> OnBackRequested;
        private void App_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (OnBackRequested != null) { OnBackRequested(this, e); }

            if (!e.Handled)
            {
                //MyFrame = Window.Current.Content as Frame;
                if (myFrame1.CanGoBack)
                {
                    myFrame1.GoBack();
                    e.Handled = true;
                }
            }
        }
        #endregion

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

  
      

        private void listitem1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            HumburgerTB.Text = "Acceuil";
            Frame.Navigate(typeof(MainPage));
            MyScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            MyScrollViewer.VerticalScrollMode = ScrollMode.Auto;
  
            MySplitView.IsPaneOpen = false;
        }

        private void listitem2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            myFrame1.Navigate(typeof(Stations));
            HumburgerTB.Text = "Stations";
            MyScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
            MyScrollViewer.VerticalScrollMode = ScrollMode.Disabled;
           
            MySplitView.IsPaneOpen = false;
        }

        private void listitem3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            myFrame1.Navigate(typeof(Fav1));
            HumburgerTB.Text = "Favorie";
            MyScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
            MyScrollViewer.VerticalScrollMode = ScrollMode.Disabled;
            
            MySplitView.IsPaneOpen = false;
        }

        private void listitem4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            myFrame1.Navigate(typeof(MapPage));
            HumburgerTB.Text = "Carte";
            MyScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
            MyScrollViewer.VerticalScrollMode = ScrollMode.Disabled;

            MySplitView.IsPaneOpen = false;
        }

        private void listitem5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
                    myFrame1.Navigate(typeof(AboutPage));
                    HumburgerTB.Text = "À propos";    

            MySplitView.IsPaneOpen = false;
            MyListBox.SelectedItem = false;
            MyScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
            MyScrollViewer.VerticalScrollMode = ScrollMode.Disabled;
        }
    }
}
