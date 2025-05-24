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

namespace SafeBacon
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            // Add 3 rows
            for (int i = 0; i < 3; i++)
            {
                MyGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 2; i++)
            {
                MyGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void onLoginClick(object sender, RoutedEventArgs e)
        {
            String usr = username.Text;
            String pswd = password.Password;

            Boolean loggedIn = true;

            if (loggedIn)
            {
                // Show the main window
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                // Show an error message
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
