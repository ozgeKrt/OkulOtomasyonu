﻿#pragma checksum "..\..\..\..\UserControls\Menu\OgrencilerMenuUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5305BA75C88E3B3B812A5283BCAD94EA19E44F48BDF42EE7FEEAEE6469C5421E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using OkulOtomasyonu.UserControls.Menu;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace OkulOtomasyonu.UserControls.Menu {
    
    
    /// <summary>
    /// OgrencilerMenuUserControl
    /// </summary>
    public partial class OgrencilerMenuUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\UserControls\Menu\OgrencilerMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewMenu;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\UserControls\Menu\OgrencilerMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem ogrenciGoruntuleme;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\UserControls\Menu\OgrencilerMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem devamsizlik;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\UserControls\Menu\OgrencilerMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem notGoruntuleme;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OkulOtomasyonu;component/usercontrols/menu/ogrencilermenuusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\Menu\OgrencilerMenuUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ListViewMenu = ((System.Windows.Controls.ListView)(target));
            
            #line 11 "..\..\..\..\UserControls\Menu\OgrencilerMenuUserControl.xaml"
            this.ListViewMenu.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ListViewMenu_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ogrenciGoruntuleme = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 3:
            this.devamsizlik = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 4:
            this.notGoruntuleme = ((System.Windows.Controls.ListViewItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

