﻿#pragma checksum "..\..\..\Interface\Profile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00F76035B11B44C40C078DAECDC9960A23F7BE5AA31D2F0CCB075403C7963056"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Toy_Magazine;


namespace Toy_Magazine {
    
    
    /// <summary>
    /// Profile
    /// </summary>
    public partial class Profile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Interface\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userlogin;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Interface\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BalanceBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Interface\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uppBalanceBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Interface\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpBalance;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Interface\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoCataloge;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Interface\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBusket;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Interface\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/Toy Magazine;component/interface/profile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interface\Profile.xaml"
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
            
            #line 11 "..\..\..\Interface\Profile.xaml"
            ((Toy_Magazine.Profile)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Interface\Profile.xaml"
            ((Toy_Magazine.Profile)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.userlogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Interface\Profile.xaml"
            this.userlogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BalanceBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Interface\Profile.xaml"
            this.BalanceBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BalanceBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.uppBalanceBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UpBalance = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Interface\Profile.xaml"
            this.UpBalance.Click += new System.Windows.RoutedEventHandler(this.UpBalance_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GoCataloge = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Interface\Profile.xaml"
            this.GoCataloge.Click += new System.Windows.RoutedEventHandler(this.GoCataloge_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GoBusket = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Interface\Profile.xaml"
            this.GoBusket.Click += new System.Windows.RoutedEventHandler(this.GoBusket_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Interface\Profile.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

