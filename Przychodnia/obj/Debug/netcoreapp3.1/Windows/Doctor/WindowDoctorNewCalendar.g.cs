#pragma checksum "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7AE03445136FB96251BC364C100296B7A5A5DD5"
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
    /// WindowDoctorNewCalendar
    /// </summary>
    public partial class WindowDoctorNewCalendar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxPickCalendar;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PreviousMonthDataGrid;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CurrentMonthDataGrid;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox workingDay;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox workingDayFrom;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox workingDayTo;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/windows/doctor/windowdoctornewcalendar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
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
            this.ComboBoxPickCalendar = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.ComboBoxPickCalendar.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxPickDate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PreviousMonthDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.CurrentMonthDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 73 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.CurrentMonthDataGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PrintInfo);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.CurrentMonthDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CurrentMonthDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.CurrentMonthDataGrid.LostFocus += new System.Windows.RoutedEventHandler(this.CurrentMonthDataGrid_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 93 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.copyPreviousMonth_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.workingDay = ((System.Windows.Controls.CheckBox)(target));
            
            #line 116 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.workingDay.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxWorkingDay_Checked);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.workingDay.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxWorkingDay_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.workingDayFrom = ((System.Windows.Controls.ComboBox)(target));
            
            #line 119 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.workingDayFrom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.workingDayFrom_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.workingDayTo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 120 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            this.workingDayTo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.workingDayTo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 127 "..\..\..\..\..\Windows\Doctor\WindowDoctorNewCalendar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_AcceptCalendarClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

