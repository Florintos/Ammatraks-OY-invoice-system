using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmatraksOY_InvoiceApplication.Model
{
    public class Client
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            return Name; // You can modify this to return any property you want to display
        }
    }
}
