using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmatraksOY_InvoiceApplication.Model
{
    public class Project
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Invoice> Invoices { get; set; }

        public override string ToString()
        {
            return Name; // You can modify this to return any property you want to display
        }
    }
}
