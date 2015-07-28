using System.Windows;


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
            if (LoginBox.Text == "admin" && PasswordBox.Text == "admin")
            {
                MessageBox.Show("Authorization successful!");
            }
        }

    }
}
