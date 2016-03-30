using System;

namespace Adex.Entidad.Models
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public string estado { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
