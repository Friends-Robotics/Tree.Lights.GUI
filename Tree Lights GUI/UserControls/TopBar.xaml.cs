using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tree_Lights_GUI.UserControls
{
    /// <summary>
    /// Interaction logic for TopBar.xaml
    /// </summary>
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();
        }

        public event EventHandler? CloseButtonClicked;
        public event EventHandler? MaximiseButtonClicked;
        public event EventHandler? MinimiseButtonClicked;

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            CloseButtonClicked?.Invoke(this, e);
        }

        private void Maximise_MouseDown(object sender, MouseButtonEventArgs e) {
            MaximiseButtonClicked?.Invoke(this, e);
        }

        private void MinimiseButton_MouseDown(object sender, MouseButtonEventArgs e) {
            MinimiseButtonClicked?.Invoke(sender, e);
        }
    }
}
