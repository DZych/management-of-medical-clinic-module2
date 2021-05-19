﻿#pragma checksum "..\..\..\..\..\Windows\Login\PageLogin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51DE542C6986BF9CDE99B6B5209B9432CD892F66"
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
using Przychodnia;
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


namespace Przychodnia.Windows.Login {
    
    
    /// <summary>
    /// PageLogin
    /// </summary>
    public partial class PageLogin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Button_IForgotPassword;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLogging;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Cancel;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockNextTry;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;V1.0.0.0;component/windows/login/pagelogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
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
            this.TextBoxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PasswordBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.Button_IForgotPassword = ((System.Windows.Controls.TextBlock)(target));
            
            #line 38 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
            this.Button_IForgotPassword.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonIForgotPassword_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonLogging = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
            this.ButtonLogging.Click += new System.Windows.RoutedEventHandler(this.ButtonLogging_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\Windows\Login\PageLogin.xaml"
            this.Button_Cancel.Click += new System.Windows.RoutedEventHandler(this.Button_Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBlockNextTry = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

