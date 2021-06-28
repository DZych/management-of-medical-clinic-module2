﻿#pragma checksum "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5F20357BFED67B2F3CAFA08E654E7076FF9A761B"
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
    /// WindowDoctorEditCalendar
    /// </summary>
    public partial class WindowDoctorEditCalendar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CurrentMonthDataGrid;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox workingDay;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox workingDayFrom;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox workingDayTo;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxChangeDay;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox availableDates;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;V1.0.0.0;component/windows/doctor/windowdoctoreditcalendar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
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
            this.CurrentMonthDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 46 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.CurrentMonthDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CurrentMonthDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.CurrentMonthDataGrid.LostFocus += new System.Windows.RoutedEventHandler(this.CurrentMonthDataGrid_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 66 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.workingDay = ((System.Windows.Controls.CheckBox)(target));
            
            #line 92 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.workingDay.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxWorkingDay_Checked);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.workingDay.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxWorkingDay_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.workingDayFrom = ((System.Windows.Controls.ComboBox)(target));
            
            #line 96 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.workingDayFrom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.workingDayFrom_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.workingDayTo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 97 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.workingDayTo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.workingDayTo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.checkBoxChangeDay = ((System.Windows.Controls.CheckBox)(target));
            
            #line 100 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.checkBoxChangeDay.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChangeDay_Checked);
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.checkBoxChangeDay.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChange_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.availableDates = ((System.Windows.Controls.ComboBox)(target));
            
            #line 103 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            this.availableDates.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.availableDates_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 112 "..\..\..\..\..\Windows\Doctor\WindowDoctorEditCalendar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.acceptChanges_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

