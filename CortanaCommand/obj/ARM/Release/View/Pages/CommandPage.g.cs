﻿#pragma checksum "C:\Users\garicchi\Projects\Repository\Windows\CortanaCommand\CortanaCommand\View\Pages\CommandPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "57840438E932EB20BBBA6F495D02F5F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CortanaCommand.View.Pages
{
    partial class CommandPage : 
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
                    this.frameState = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 2:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.textBlock_Copy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.textBox1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.listBoxState = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 41 "..\..\..\..\View\Pages\CommandPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.listBoxState).ItemClick += this.listBoxState_ItemClick;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.Grid element6 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 49 "..\..\..\..\View\Pages\CommandPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element6).RightTapped += this.Grid_RightTapped;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element7 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 53 "..\..\..\..\View\Pages\CommandPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element7).Click += this.menuItemState_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
