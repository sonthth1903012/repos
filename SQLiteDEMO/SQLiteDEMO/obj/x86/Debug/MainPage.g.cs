﻿#pragma checksum "C:\Users\jngst\source\repos\SQLiteDemo\SQLiteDEMO\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B9EEA0884A7782CDA153A0CAFDDC1ECF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLiteDEMO
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.Retrieve = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Retrieve).Click += this.Retrieve_Click;
                }
                break;
            case 3: // MainPage.xaml line 18
                {
                    this.Add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Add).Click += this.Add_Click;
                }
                break;
            case 4: // MainPage.xaml line 25
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // MainPage.xaml line 33
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 40
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 48
                {
                    this.textBox1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // MainPage.xaml line 55
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

