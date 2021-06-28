﻿#pragma checksum "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6CAE99685259E6ACDB9C43A9A65CFB47C4AA6F97"
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


namespace Przychodnia.Windows.Doctor {
    
    
    /// <summary>
    /// WindowDoctorEditCalendarAdd
    /// </summary>
    public partial class WindowDoctorEditCalendarAdd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox workingDayFrom;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox workingDayTo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AvailableDate;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;V1.0.0.0;component/windows/doctor/windowdoctoreditcalendaradd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
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
            this.workingDayFrom = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
            this.workingDayFrom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AddWorkingDayFrom_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.workingDayTo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 46 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
            this.workingDayTo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AddWorkingDayTo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AvailableDate = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
            this.AvailableDate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AddWorkingDayDate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 61 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 62 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendarAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

