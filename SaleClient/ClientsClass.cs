using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleClient
{
    public class ClientsClass
    {
        public class Client
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Patronymic { get; set; }
        }
        public class Telephone
        {
            public int Articul { get; set; }
            public string NameTelephone { get; set; }
            public string Category { get; set; }
            public decimal Cost { get; set; }
            public int Count { get; set; }
            public string Manufacturer { get; set; }
        }
        public class Sale
        {
            public DateTime DateSale { get; set; }
            public Client Client { get; set; }
            public List<Telephone> Telephones { get; set; }

        }
    }
}
