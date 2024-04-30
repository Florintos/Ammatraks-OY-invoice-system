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
    /// Interaction logic for WorkerMainWindow.xaml
    /// </summary>
    public partial class WorkerMainWindow : Window
    {
        public WorkerMainWindow()
        {
            InitializeComponent();
        }

        private void LogOut_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
