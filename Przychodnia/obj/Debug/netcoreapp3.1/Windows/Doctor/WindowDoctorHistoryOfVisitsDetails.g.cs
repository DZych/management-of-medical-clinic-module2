#pragma checksum "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B52BDB135A55313EA58D701B6068D6EAAE45A753"
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
    /// WindowDoctorHistoryOfVisitsDetails
    /// </summary>
    public partial class WindowDoctorHistoryOfVisitsDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DetailsName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DetailsSurname;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DetailsPesel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DetailsPhone;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DetailsTopic;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DetailsResultOfVisit;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseDetailsButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/windows/doctor/windowdoctorhistoryofvisitsdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
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
            this.DetailsName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.DetailsSurname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.DetailsPesel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DetailsPhone = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.DetailsTopic = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DetailsResultOfVisit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CloseDetailsButton = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\Windows\Doctor\WindowDoctorHistoryOfVisitsDetails.xaml"
            this.CloseDetailsButton.Click += new System.Windows.RoutedEventHandler(this.CloseDetailsButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

