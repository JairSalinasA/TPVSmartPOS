using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVVentaExpress.Domain.ValueObjects
{
    public class ProductCode
    {
        public string Code { get; }

        public ProductCode(string code)
        {
            Code = code;
        }

        // Equals and GetHashCode methods
    }

}
