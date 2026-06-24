using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();

        dialog.Filter = "Text files (*.txt)|*.txt";


        if (dialog.ShowDialog() == true)
        {
            string text = File.ReadAllText(dialog.FileName);

            textBox1.Text = text;
        }
    }
}