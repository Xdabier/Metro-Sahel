﻿#pragma checksum "C:\Users\SAIBIOUSSAMA\Documents\Visual Studio 2015\Projects\MetroSAHEL_2\MetroSAHEL_2\MapPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3CD5CC9B786BE40DFEA0CAF2058693D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetroSAHEL_2
{
    partial class MapPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.LocaionAnim1 = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3:
                {
                    this.directionAnim = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 4:
                {
                    this.Grid1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.StationListView1 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 100 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.StationListView1).ItemClick += this.StationListView1_ItemClick;
                    #line default
                }
                break;
            case 6:
                {
                    this.MyMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 7:
                {
                    this.ClearMapButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ClearMapButton).Click += this.ClearMapButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.MapStyleButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element9 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 88 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element9).Click += this.MenuFlyoutItem_Click;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element10 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 90 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element10).Click += this.MenuFlyoutItem_Click_1;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element11 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 92 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element11).Click += this.MenuFlyoutItem_Click_2;
                    #line default
                }
                break;
            case 12:
                {
                    this.GetPositionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GetPositionButton).Click += this.GetPositionButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.ZoomOutButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 52 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ZoomOutButton).Click += this.ZoomOutButton_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.directionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 61 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.directionButton).Click += this.directionButton_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.directionTb = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.LocTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

