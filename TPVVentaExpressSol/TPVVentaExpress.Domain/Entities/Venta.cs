using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVVentaExpress.Domain.Entities
{
    public class Venta
    {
        public int VentaID { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        public decimal Total { get; set; }

        // Otros campos y métodos según sea necesario
    }
}
