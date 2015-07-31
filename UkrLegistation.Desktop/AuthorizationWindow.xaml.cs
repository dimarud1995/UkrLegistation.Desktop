using System.Collections.Generic;
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
            List<User> users = new List<User>();
            bool flag;
            UserJson.GetData(out users, out flag);
            foreach (var user in users)
            {
                if (LoginBox.Text == user.login && PasswordBox.Text == user.password && user.role == "admin")
                {
                    AdminWindow admin = new AdminWindow();
                    admin.Show();
                    this.Close();
                    break;
                }
                else
                {
                    if (flag) break;
                    ErrorAuthorization authErr = new ErrorAuthorization();
                    authErr.Show();
                    break;
                }
            }            
        }
    }
}
