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

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e) {
            // Normally when the window maximises it goes off the edge of the screen
            // This is because the WindowStyle is set to none
            // To workaround this the border size is resized to deal with this
            if (WindowState == WindowState.Maximized) {
                BorderThickness = new Thickness(8);
            }
            else {
                BorderThickness = new Thickness(0);
            }
        }
    }
}
