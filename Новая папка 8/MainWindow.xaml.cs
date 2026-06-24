using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Rectangle r = new Rectangle();

        r.Width = 100;
        r.Height = 100;
        r.Fill = Brushes.Red;

        canvas1.Children.Add(r);
    }
}