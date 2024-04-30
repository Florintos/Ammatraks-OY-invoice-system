using AmmatraksOY_InvoiceApplication.Model;
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
    public partial class ArchivesDemo : Window
    {
        private List<Client> clients;

        public ArchivesDemo()
        {
            InitializeComponent();

            // Initialize sample data
            InitializeData();

            // Populate the client listbox
            clientListBox.ItemsSource = clients;

            // Set selection change event handlers
            clientListBox.SelectionChanged += ClientListBox_SelectionChanged;
            projectListBox.SelectionChanged += ProjectListBox_SelectionChanged;
        }

        private void InitializeData()
        {
            // Initialize clients
            clients = new List<Client>
            {
                new Client
                {
                    Name = "Client 1",
                    ID = 1,
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Name = "Project 1",
                            ID = 1,
                            Invoices = new List<Invoice>
                            {
                                new Invoice {Date = new System.DateTime(2024, 4, 25), ID = 1, PaymentDate = new System.DateTime(2024, 5, 10)},
                                new Invoice {Date = new System.DateTime(2024, 4, 26), ID = 2, PaymentDate = new System.DateTime(2024, 5, 11)}
                            }
                        }
                    }
                }
            };
        }

        private void ClientListBox_SelectionChanged(object sender, RoutedEventArgs e)
        {

            invoiceListBox.ItemsSource = null;

            if (clientListBox.SelectedItem != null)
            {
                var selectedClient = (Client)clientListBox.SelectedItem;
                projectListBox.ItemsSource = selectedClient.Projects;
            }
        }

        // Event handler for project selection change
        private void ProjectListBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (projectListBox.SelectedItem != null)
            {
                var selectedProject = (Project)projectListBox.SelectedItem;
                invoiceListBox.ItemsSource = selectedProject.Invoices;
            }
        }

        private void Return_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMenu = new AdminMainWindow();
            adminMenu.Show();
            this.Close();
        }

        // Event handler for Add Client button click
        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            OpenAddClientWindow();
        }

        // Event handler for Add Project button click
        private void btnAddProject_Click(object sender, RoutedEventArgs e)
        {
            if (clientListBox.SelectedItem != null && clientListBox.SelectedItem is Client selectedClient)
            {
                OpenAddProjectWindow(selectedClient);
            }
            else
            {
                MessageBox.Show("Please select a client first.");
            }
        }

        // Event handler for Add Invoice button click
        private void btnAddInvoice_Click(object sender, RoutedEventArgs e)
        {
            if (projectListBox.SelectedItem != null && projectListBox.SelectedItem is Project selectedProject)
            {
                OpenAddInvoiceWindow(selectedProject);
            }
            else
            {
                MessageBox.Show("Please select a client first.");
            }
        }

        // Method to open AddClientDataWindow
        private void OpenAddClientWindow()
        {
            AddClientDataWindow addClientWindow = new AddClientDataWindow();
            if (addClientWindow.ShowDialog() == true) // ShowDialog() returns true if the user clicks "Save"
            {
                // Retrieve the new client object from the AddClientDataWindow
                Client newClient = addClientWindow.NewClient;

                // Add the new client to the clients list and refresh the ListBox
                if (newClient != null)
                {
                    clients.Add(newClient);
                    clientListBox.ItemsSource = null;
                    clientListBox.ItemsSource = clients;
                }
            }
        }

        // Method to open AddProjectDataWindow
        private void OpenAddProjectWindow(Client selectedClient)
        {
            AddProjectDataWindow addProjectWindow = new AddProjectDataWindow(selectedClient);
            addProjectWindow.ShowDialog();
            // Handle data added in the AddProjectDataWindow if needed
        }

        // Method to open AddInvoiceDataWindow
        private void OpenAddInvoiceWindow(Project selectedProject)
        {
            AddInvoiceDataWindow addInvoiceWindow = new AddInvoiceDataWindow(selectedProject);
            addInvoiceWindow.ShowDialog();
            // Handle data added in the AddInvoiceDataWindow if needed
        }
    }
}
