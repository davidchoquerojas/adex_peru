using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adex.Entidad.Models
{
    public class VentaDetalle
    {
        public int id_Venta_detalle { get; set; }
        public int id_venta { get; set; }
        public int id_producto { get; set; }
        public DateTime fech_registro { get; set; }
    }
}
