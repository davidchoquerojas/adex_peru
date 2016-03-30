using Adex.Datos.data;
using Adex.Entidad.Models;
using System;
using System.Collections.Generic;

namespace Adex.Negocio.logica
{
    public class NCliente
    {
        public Int32 save(Cliente cliente)
        {
            return new DCliente().save(cliente);
        }

        public List<Cliente> list()
        {
            return new DCliente().list();
        }
    }
}
