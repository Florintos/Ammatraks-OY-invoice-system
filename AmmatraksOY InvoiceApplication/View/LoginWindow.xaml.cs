using AmmatraksOY_InvoiceApplication.Model;
using AmmatraksOY_InvoiceApplication.ViewModel;
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
using System.Windows.Shapes;

namespace AmmatraksOY_InvoiceApplication.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UserManager userManager;

        public LoginWindow()
        {
            InitializeComponent();

            // Initialize the UserManager
            userManager = new UserManager();

            // Add some sample users (you can replace this with your actual user initialization logic)
            userManager.AddUser(new Worker { Username = "worker", Password = "1234" });
            userManager.AddUser(new Admin { Username = "admin", Password = "1234" });
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Password;

            User authenticatedUser = userManager.Authenticate(username, password);
            if (authenticatedUser != null)
            {
                if (authenticatedUser is Worker)
                {
                    // If the authenticated user is a Worker, navigate to Worker's main window
                    WorkerMainWindow workerMainWindow = new WorkerMainWindow();
                    workerMainWindow.Show();
                    this.Close();
                }
                else if (authenticatedUser is Admin)
                {
                    // If the authenticated user is an Admin, navigate to Admin's main window
                    AdminMainWindow adminMainWindow = new AdminMainWindow();
                    adminMainWindow.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
