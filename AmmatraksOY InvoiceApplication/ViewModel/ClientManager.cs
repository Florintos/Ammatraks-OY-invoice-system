using AmmatraksOY_InvoiceApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmatraksOY_InvoiceApplication.ViewModel
{
    public class ClientManager
    {
        private List<Client> clients;

        public ClientManager()
        {
            clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }
    }
}
