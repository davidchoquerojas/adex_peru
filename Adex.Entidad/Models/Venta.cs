using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adex.Entidad.Models
{
    public class Venta
    {
        public int id_venta { get; set; }
        public int id_cliente { get; set; }
        public Decimal total_cost { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
