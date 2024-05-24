using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVVentaExpress.Domain.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }

        // Lista de detalles de la venta
        public List<SaleDetail> SaleDetails { get; set; }

        // Relaciones de navegación
        public Customer Customer { get; set; }
    }


}
