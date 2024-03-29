﻿#pragma checksum "..\..\..\GameScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574CDF578674D4739B4AADC9329925AFA0129847"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
using VierGewinntWPF;


namespace VierGewinntWPF {
    
    
    /// <summary>
    /// GameScreen
    /// </summary>
    public partial class GameScreen : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid maingrid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition CanvasCol;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GameStatus;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button History;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Restart;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Board_Width;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Board_Height;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BoardWLabel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BoardHLabel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BoardChange;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse PlayerTurn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Player1Name;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Player2Name;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Player1C;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Player2C;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox vsComputer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VierGewinntWPF;component/gamescreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GameScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.maingrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.CanvasCol = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.GameStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.History = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\GameScreen.xaml"
            this.History.Click += new System.Windows.RoutedEventHandler(this.History_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Restart = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\GameScreen.xaml"
            this.Restart.Click += new System.Windows.RoutedEventHandler(this.Restart_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Board_Width = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Board_Height = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BoardWLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.BoardHLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.BoardChange = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\GameScreen.xaml"
            this.BoardChange.Click += new System.Windows.RoutedEventHandler(this.BoardChange_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.PlayerTurn = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 13:
            this.Player1Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.Player2Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.Player1C = ((System.Windows.Controls.ComboBox)(target));
            
            #line 46 "..\..\..\GameScreen.xaml"
            this.Player1C.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Player1C_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Player2C = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\..\GameScreen.xaml"
            this.Player2C.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Player2C_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.vsComputer = ((System.Windows.Controls.CheckBox)(target));
            
            #line 58 "..\..\..\GameScreen.xaml"
            this.vsComputer.Checked += new System.Windows.RoutedEventHandler(this.Checked);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\GameScreen.xaml"
            this.vsComputer.Unchecked += new System.Windows.RoutedEventHandler(this.Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

