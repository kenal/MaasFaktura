﻿#pragma checksum "..\..\AdminEditWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9E6A511BDF8D8E70403D353EC628D09"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using System.Windows.Interactivity;
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


namespace Desktop {
    
    
    /// <summary>
    /// AdminEditWindow
    /// </summary>
    public partial class AdminEditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Desktop.AdminEditWindow Window;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdNew;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idLastName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idEmail;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTelefon;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idUsername;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idPassword;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AdminEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker idLicence;
        
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
            System.Uri resourceLocater = new System.Uri("/Desktop;component/admineditwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminEditWindow.xaml"
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
            this.Window = ((Desktop.AdminEditWindow)(target));
            return;
            case 2:
            this.grdNew = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.idName = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\AdminEditWindow.xaml"
            this.idName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.idLastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\AdminEditWindow.xaml"
            this.idLastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.idLastName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.idEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\AdminEditWindow.xaml"
            this.idEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.idEmail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.idTelefon = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\AdminEditWindow.xaml"
            this.idTelefon.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.idTelefon_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.idUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\AdminEditWindow.xaml"
            this.idUsername.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.idUsername_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.idPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\AdminEditWindow.xaml"
            this.idPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.idPassword_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.idLicence = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

