﻿#pragma checksum "..\..\..\Dijalozi\PrikazEtiketa.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC8B298B56B7CAD8C82899158E4343045BBCD650"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI_projekat.Dijalozi;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace HCI_projekat.Dijalozi {
    
    
    /// <summary>
    /// PrikazEtiketa
    /// </summary>
    public partial class PrikazEtiketa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZatvoriButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ObrisiButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajButton;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI_projekat;component/dijalozi/prikazetiketa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
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
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.ZatvoriButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
            this.ZatvoriButton.Click += new System.Windows.RoutedEventHandler(this.ZatvoriButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ObrisiButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
            this.ObrisiButton.Click += new System.Windows.RoutedEventHandler(this.ObrisiButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DodajButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Dijalozi\PrikazEtiketa.xaml"
            this.DodajButton.Click += new System.Windows.RoutedEventHandler(this.DodajButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

