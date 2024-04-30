using AmmatraksOY_InvoiceApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for WorkerMenuWindow.xaml
    /// </summary>
    public partial class WorkerMenuWindow : Window
    {
        public ObservableCollection<Worker> Workers { get; set; }
        public WorkerMenuWindow()
        {
            InitializeComponent();

            InitializeComponent();
            Workers = new ObservableCollection<Worker>();
            workerListBox.ItemsSource = Workers;

            // Example data
            Workers.Add(new Worker { Name = "John Doe", ID = 1, PhoneNumber = "555-1234", Email = "JohnDoeTheLegend1993@example.com" });
            Workers.Add(new Worker { Name = "Jane Smith", ID = 2, PhoneNumber = "555-4321", Email = "JohnDoesBitch@example.com" });
        }

        private void Return_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMenu = new AdminMainWindow();
            adminMenu.Show();
            this.Close();
        }
    }
}
