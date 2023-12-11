using System;
using System.Windows.Input;
using System.Windows.Controls;
using FontAwesome.Sharp;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Windows.Application;

namespace Tree_Lights_GUI.UserControls {
    /// <summary>
    /// Interaction logic for TopBar.xaml
    /// </summary>
    public partial class TopBar : UserControl {

        public TopBar() {
            InitializeComponent();
        }


        public IconChar MaximiseRestoreIcon {
            get { return (IconChar)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MaximiseRestoreIcon", typeof(IconChar), typeof(TopBar), new PropertyMetadata(0));


        public IconChar RestoreMaximiseIcon { get; set; }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            Current.Shutdown();
        }

        private void RestoreMaximiseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            Current.MainWindow.WindowState = Current.MainWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void MinimiseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
