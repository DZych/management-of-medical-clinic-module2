﻿#pragma checksum "..\..\..\WindowAdministrator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E0BA92BFD6F6EA3BAD68D8F5A51EBD28EB86844A"
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


namespace Przychodnia {
    
    
    /// <summary>
    /// WindowAdministrator
    /// </summary>
    public partial class WindowAdministrator : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\WindowAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl TabControlMain;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\WindowAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameDoctor;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\WindowAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameEmployee;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\WindowAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameUser;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\WindowAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameOffice;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\WindowAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameCalendar;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/windowadministrator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowAdministrator.xaml"
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
            this.TabControlMain = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.FrameDoctor = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.FrameEmployee = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            this.FrameUser = ((System.Windows.Controls.Frame)(target));
            return;
            case 5:
            this.FrameOffice = ((System.Windows.Controls.Frame)(target));
            return;
            case 6:
            this.FrameCalendar = ((System.Windows.Controls.Frame)(target));
            return;
            case 7:
            
            #line 76 "..\..\..\WindowAdministrator.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseLeftButtonUp_Refresh);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 85 "..\..\..\WindowAdministrator.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

