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
    /// Interaction logic for ArchivesMenuWindow.xaml
    /// </summary>
    public partial class ArchivesMenuWindow : Window
    {
        public ObservableCollection<Client> Clients { get; set; }
        public ObservableCollection<Project> Projects { get; set; }

        public ArchivesMenuWindow()
        {
            InitializeComponent();

            Clients = new ObservableCollection<Client>();
            ClientListBox.ItemsSource = Clients;

            Clients.Add(new Client { Name = "Autopesu OY", ID = 123, PhoneNumber = "12345678", Email = "AutopesuOY@example.com" });
            Clients.Add(new Client { Name = "Nigger OY", ID = 123, PhoneNumber = "87654321", Email = "NiggerOY@example.com" });

            Projects = new ObservableCollection<Project>();
            ProjectListBox.ItemsSource = Projects;

            Projects.Add(new Project { Name = "Nigger", ID = 123 });
        }

        private void Return_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMenu = new AdminMainWindow();
            adminMenu.Show();
            this.Close();
        }
    }
}
