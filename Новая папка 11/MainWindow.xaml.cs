using System.Windows;


namespace WpfApp1;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
    }



    private void Login_Click(object sender, RoutedEventArgs e)
    {
        if(loginBox.Text == "admin" &&
           passBox.Password == "123")
        {
            loginPanel.Visibility = Visibility.Hidden;

            cabinetPanel.Visibility = Visibility.Visible;
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль");
        }
    }




    private void Profile_Click(object sender, RoutedEventArgs e)
    {
        profilePanel.Visibility = Visibility.Visible;
        settingsPanel.Visibility = Visibility.Hidden;
        ordersPanel.Visibility = Visibility.Hidden;
    }



    private void Settings_Click(object sender, RoutedEventArgs e)
    {
        profilePanel.Visibility = Visibility.Hidden;
        settingsPanel.Visibility = Visibility.Visible;
        ordersPanel.Visibility = Visibility.Hidden;
    }



    private void Orders_Click(object sender, RoutedEventArgs e)
    {
        profilePanel.Visibility = Visibility.Hidden;
        settingsPanel.Visibility = Visibility.Hidden;
        ordersPanel.Visibility = Visibility.Visible;
    }




    private void Save_Click(object sender, RoutedEventArgs e)
    {
        fio.Text = "ФИО: " + newFio.Text;
        phone.Text = "Телефон: " + newPhone.Text;
        email.Text = "Email: " + newEmail.Text;


        MessageBox.Show("Данные сохранены");
    }

}


//ЛОГИН       admin
//ПАРОЛЬ      123