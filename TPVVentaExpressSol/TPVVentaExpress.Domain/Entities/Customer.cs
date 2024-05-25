using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.ValueObjects;

namespace TPVVentaExpress.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
    }

}
