﻿#pragma checksum "C:\Users\SAIBIOUSSAMA\Documents\GitHub\Metro-Sahel\MetroSAHEL_2\FirstPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAE9EB77EE25799695B599E4C9112ADD"
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
    partial class FirstPage : 
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
                    this.startPage = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4:
                {
                    this.CheckedButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\FirstPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CheckedButton).Click += this.CheckedButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.MyCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 43 "..\..\..\FirstPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.MyCheckBox).Checked += this.CheckBox_Checked;
                    #line default
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

