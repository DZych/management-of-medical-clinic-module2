﻿#pragma checksum "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59048095786CC4A5AA27F2C7B53326AC42AEEB18"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Przychodnia.Windows.DictionariesHandling;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Przychodnia.Windows.DictionariesHandling {
    
    
    /// <summary>
    /// WindowOverlapping
    /// </summary>
    public partial class WindowOverlapping : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridListOfDoctors;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonChange;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Przychodnia;V1.0.0.0;component/windows/calendar/windowoverlapping.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
            ((Przychodnia.Windows.DictionariesHandling.WindowOverlapping)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridListOfDoctors = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
            this.DataGridListOfDoctors.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGridListOfDoctors_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonChange = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
            this.ButtonChange.Click += new System.Windows.RoutedEventHandler(this.ButtonChange_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\Windows\Calendar\WindowOverlapping.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

