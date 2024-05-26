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

    public class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Propiedad de navegación hacia la entidad Sale
        public Sale Sale { get; set; }

        // Relación de navegación con la entidad Product
        public virtual Product Product { get; set; }
    }



}
