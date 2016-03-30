using System;

namespace Adex.Entidad.Models
{
    public class Producto
    {
        public int id_servicio { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string estado { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
