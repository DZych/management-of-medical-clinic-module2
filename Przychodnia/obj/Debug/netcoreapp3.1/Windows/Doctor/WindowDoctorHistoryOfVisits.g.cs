﻿#pragma checksum "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisits.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79D5A76E42597B9D1E1A04DF57DC540712B47E37"
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
using Przychodnia.Windows.Doctor;
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


namespace Przychodnia.Windows.Doctor {
    
    
    /// <summary>
    /// WindowDoctorHistoryOfVisits
    /// </summary>
    public partial class WindowDoctorHistoryOfVisits : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid HistoryOfVisits;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowDetails;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchVisitsHistory;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/windows/doctor/windowdoctorhistoryofvisits.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisits.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HistoryOfVisits = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.ShowDetails = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisits.xaml"
            this.ShowDetails.Click += new System.Windows.RoutedEventHandler(this.ShowDetails_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchVisitsHistory = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisits.xaml"
            this.SearchVisitsHistory.Click += new System.Windows.RoutedEventHandler(this.SearchVisitsHistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

