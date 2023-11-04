using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tree_Lights_GUI.UserControls; 

/// <summary>
/// Interaction logic for LoadingSpinner.xaml
/// </summary>
public partial class LoadingSpinner : UserControl
{
    public LoadingSpinner() {
        InitializeComponent();
    }

    public Duration Duration {
        get { return (Duration)GetValue(DurationProperty); }
        set { SetValue(DurationProperty, value); }
    }

    public static readonly DependencyProperty DurationProperty =
        DependencyProperty.Register("Duration", typeof(Duration), typeof(LoadingSpinner), new PropertyMetadata(default(Duration)));

    public Brush SpinnerColor {
        get { return (Brush)GetValue(SpinnerColorProperty); }
        set { SetValue(SpinnerColorProperty, value); }
    }

    public static readonly DependencyProperty SpinnerColorProperty =
        DependencyProperty.Register("SpinnerColor", typeof(Brush), typeof(LoadingSpinner), new PropertyMetadata(Brushes.DodgerBlue));
}