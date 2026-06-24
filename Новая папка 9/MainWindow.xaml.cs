using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        BitmapImage img = new BitmapImage();

        img.BeginInit();
        img.UriSource = new Uri("image.jpg", UriKind.Relative);
        img.EndInit();


        DrawingVisual visual = new DrawingVisual();

        using (DrawingContext dc = visual.RenderOpen())
        {
            dc.DrawImage(img, new Rect(0, 0, 300, 300));
        }


        RenderTargetBitmap bmp = new RenderTargetBitmap(
            300,
            300,
            96,
            96,
            PixelFormats.Pbgra32);

        bmp.Render(visual);

        image1.Source = bmp;
    }
}