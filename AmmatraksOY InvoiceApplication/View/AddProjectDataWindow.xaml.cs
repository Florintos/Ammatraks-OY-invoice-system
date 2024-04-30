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
    /// <summary>
    /// Interaction logic for AddProjectDataWindow.xaml
    /// </summary>
    public partial class AddProjectDataWindow : Window
    {
        private Client selectedClient;

        // Constructor with a parameter to accept the selected client
        public AddProjectDataWindow(Client client)
        {
            InitializeComponent();
            selectedClient = client;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve data entered by the user
            int projectID = int.Parse(txtProjectID.Text);
            string projectName = txtProjectName.Text;
            string projectDescription = txtProjectDescription.Text;
            // Parse worker data or handle worker selection here

            // Create new Project object
            Project newProject = new Project
            {
                ID = projectID,
                Name = projectName,
                Description = projectDescription
                // Assign workers to the project
            };

            // Close the window and return the new project object to the MainWindow
            DialogResult = true;
        }
    }
}
