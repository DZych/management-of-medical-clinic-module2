﻿#pragma checksum "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17C788BC3D2BA97A9CA437CB7AE9B13D5A45AE06"
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
    /// PageCalendar
    /// </summary>
    public partial class PageCalendar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemove;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridListOfDoctors;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridListOfCalendarDoctor;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxPickDate;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemoveCalendar;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Status_Label;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonGenerate;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonVerified;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonShare;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/windows/calendar/pagecalendar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
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
            
            #line 13 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            ((Przychodnia.Windows.DictionariesHandling.PageCalendar)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonRemove = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.ButtonRemove.Click += new System.Windows.RoutedEventHandler(this.ButtonRemove_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGridListOfDoctors = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.DataGridListOfDoctors.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataGridListOfCalendarDoctor = ((System.Windows.Controls.DataGrid)(target));
            
            #line 56 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.DataGridListOfCalendarDoctor.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGridListOfCalendarDoctor_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ComboBoxPickDate = ((System.Windows.Controls.ComboBox)(target));
            
            #line 88 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.ComboBoxPickDate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxPickDate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonRemoveCalendar = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.ButtonRemoveCalendar.Click += new System.Windows.RoutedEventHandler(this.ButtonRemoveCalendar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Status_Label = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ButtonGenerate = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.ButtonGenerate.Click += new System.Windows.RoutedEventHandler(this.ButtonGenerate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonVerified = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.ButtonVerified.Click += new System.Windows.RoutedEventHandler(this.ButtonVerified_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonShare = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\..\..\Windows\Calendar\PageCalendar.xaml"
            this.ButtonShare.Click += new System.Windows.RoutedEventHandler(this.ButtonShare_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

