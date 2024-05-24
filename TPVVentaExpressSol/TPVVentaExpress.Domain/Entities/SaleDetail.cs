using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVVentaExpress.Domain.Entities
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }       // Identificador único del detalle de la venta
        public int SaleId { get; set; }             // Identificador de la venta asociada
        public int ProductId { get; set; }          // Identificador del producto vendido
        public int Quantity { get; set; }           // Cantidad del producto vendido
        public decimal UnitPrice { get; set; }      // Precio unitario del producto vendido

        // Relaciones de navegación
        public Sale Sale { get; set; }              // La venta asociada a este detalle
        public Product Product { get; set; }        // El producto asociado a este detalle
    }

}
