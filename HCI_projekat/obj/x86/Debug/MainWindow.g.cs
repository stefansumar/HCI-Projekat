﻿#pragma checksum "..\..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "15C6463258FA1DF8775605303C519602EC1CEB2D1369B70E0999DB4F42BB9E53"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI_projekat.Validacija;
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


namespace HCI_projekat {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EtiketaTutorijalMI;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasMap;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SacuvajVrste_Button;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SacuvajTipove_Button;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SacuvajEtikete_Button;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button obrisiButton;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI_projekat;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            
            #line 10 "..\..\..\MainWindow.xaml"
            ((HCI_projekat.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.IzadjiIzPrograma_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UnosVrsteClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UnosTipaVrsteClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UnosEtiketeClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.PrikaziVrsteClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 24 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.PrikaziTipoveClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 26 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.PrikaziEtiketeClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 29 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SacuvajVrste_Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 31 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SacuvajTipove_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 33 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SacuvajEtikete_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EtiketaTutorijalMI = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\..\MainWindow.xaml"
            this.EtiketaTutorijalMI.Click += new System.Windows.RoutedEventHandler(this.EtiketaTutorijalMI_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.canvasMap = ((System.Windows.Controls.Canvas)(target));
            
            #line 52 "..\..\..\MainWindow.xaml"
            this.canvasMap.Drop += new System.Windows.DragEventHandler(this.MapImageView_OnDrop);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\MainWindow.xaml"
            this.canvasMap.DragEnter += new System.Windows.DragEventHandler(this.MapImageView_OnDragEnter);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 58 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UnosVrsteClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 59 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UnosTipaVrsteClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 60 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UnosEtiketeClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 63 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrikaziVrsteClick);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 64 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrikaziTipoveClick);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 65 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrikaziEtiketeClick);
            
            #line default
            #line hidden
            return;
            case 19:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 20:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 21:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 22:
            this.SacuvajVrste_Button = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\MainWindow.xaml"
            this.SacuvajVrste_Button.Click += new System.Windows.RoutedEventHandler(this.SacuvajVrste_Button_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.SacuvajTipove_Button = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\MainWindow.xaml"
            this.SacuvajTipove_Button.Click += new System.Windows.RoutedEventHandler(this.SacuvajTipove_Button_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.SacuvajEtikete_Button = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\MainWindow.xaml"
            this.SacuvajEtikete_Button.Click += new System.Windows.RoutedEventHandler(this.SacuvajEtikete_Button_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 72 "..\..\..\MainWindow.xaml"
            this.listView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListView_OnMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\MainWindow.xaml"
            this.listView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 28:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.obrisiButton = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\MainWindow.xaml"
            this.obrisiButton.Click += new System.Windows.RoutedEventHandler(this.ObrisiButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 26:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewKeyDownEvent;
            
            #line 75 "..\..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyEventHandler(this.EventSetter_OnHandler);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 27:
            
            #line 83 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Icon_OnMouseMove);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Icon_OnPreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
