using System.Windows;
using UkrLegistation.Desktop.Json;
using UkrLegistation.Desktop.Model;


namespace UkrLegistation.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            UserJson.GetData(out user);

            if (LoginBox.Text == user.login && PasswordBox.Text == user.password && user.role == "admin")
            {
                MessageBox.Show("Hello admin :)");
            }
           else
            {
                MessageBox.Show("Bye user :(");
            }
        }

    }
}
