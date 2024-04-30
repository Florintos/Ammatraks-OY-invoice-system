using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AmmatraksOY_InvoiceApplication.Model
{
    public class Invoice
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaymentDate { get; set; }

        public override string ToString()
        {
            return "Invoice" + "  #" + ID; // You can modify this to return any property you want to display
        }
    }
}
