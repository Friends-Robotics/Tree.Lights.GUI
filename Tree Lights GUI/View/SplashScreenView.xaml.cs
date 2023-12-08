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

        private void TopBar_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed) {
                DragMove();
            }
        }

        private void TopBar_CloseButtonClicked(object sender, System.EventArgs e) {
            Close();
        }

        private void TopBar_MinimiseButtonClicked(object sender, System.EventArgs e) {
            WindowState = WindowState.Minimized;
        }

        private void TopBar_MaximiseButtonClicked(object sender, System.EventArgs e) {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }
    }
}
