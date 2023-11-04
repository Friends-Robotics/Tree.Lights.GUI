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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            if(e.LeftButton == MouseButtonState.Pressed) {
                DragMove();
            }
        }

        private void LoadingSpinner_Loaded(object sender, RoutedEventArgs e) {

        }
    }
}
