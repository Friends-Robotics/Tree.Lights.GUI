using System.Windows;
using System.Windows.Input;

namespace Tree_Lights_GUI.View {
    /// <summary>
    /// Interaction logic for SplashScreenView.xaml
    /// </summary>
    public partial class SplashScreenView : Window
    {
        public SplashScreenView()
        {
            InitializeComponent();
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            Close();
        }

        private void MaximiseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            WindowState = WindowState.Maximized;
        }

        private void MinimiseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            WindowState = WindowState.Minimized;
        }

        private void TopBar_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed) {
                DragMove();
            }
        }
    }
}
