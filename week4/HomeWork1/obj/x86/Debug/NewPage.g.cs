﻿#pragma checksum "D:\MOSAD\week4\HomeWork1\NewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53F2B7F19A2F275BE4C0D1B696130A31"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App4.Assets
{
    partial class NewPage : 
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
                    this.DeleteAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 11 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.DeleteAppBarButton).Click += this.DeleteAppBarButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 32 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Back).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.MainPageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.AddItemStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.CreateButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 49 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CreateButton).Click += this.CreateButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.CancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CancelButton).Click += this.CancelButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.SelectImgButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 39 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SelectImgButton).Click += this.SelectImgButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.PictureSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 9:
                {
                    this.TitleTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.DetailTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.Datepicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 12:
                {
                    this.Image = (global::Windows.UI.Xaml.Controls.Image)(target);
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

