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
    /// Interaction logic for AddInvoiceDataWindow.xaml
    /// </summary>
    public partial class AddInvoiceDataWindow : Window
    {
        private Project selectedProject;

        public AddInvoiceDataWindow(Project project)
        {
            InitializeComponent();
            selectedProject = project;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve data entered by the user
            int invoiceID = int.Parse(txtInvoiceID.Text);
            DateTime invoiceDate = DateTime.Parse(txtInvoiceDate.Text);
            DateTime paymentDate = DateTime.Parse(txtInvoicePayment.Text);

            // Create new Invoice object
            Invoice newInvoice = new Invoice
            {
                ID = invoiceID,
                Date = invoiceDate,
                PaymentDate = paymentDate
            };

            // Close the window and return the new invoice object to the MainWindow
            DialogResult = true;
        }
    }
}
