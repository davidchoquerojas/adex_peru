using System;
using Adex.Entidad.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace Adex.Datos.data
{
    public class DCliente
    {
        public Int32 save(Cliente cliente)
        {
            var queryString = @"INSERT INTO cliente(nombre,apellidos,correo,estado,fecha_registro)
                               VALUES(@nombre,@apellidos,@correo,@estado,@fecha_registro)";
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["adex_cnn"].ConnectionString))
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = queryString;
                    command.CommandType = CommandType.Text;

                    command.Parameters.Clear();
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                    command.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellidos;
                    command.Parameters.Add("@correo", SqlDbType.VarChar).Value = cliente.correo;
                    command.Parameters.Add("@estado", SqlDbType.Char).Value = cliente.estado;
                    command.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = cliente.fecha_registro;
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex )
            {
                throw(new Exception(ex.Message,ex.InnerException));
            }
        }

        public List<Cliente> list()
        {
            var listCliente = new List<Cliente>();
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["adex_cnn"].ConnectionString))
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = "SELECT * FROM cliente";
                    command.CommandType = CommandType.Text;

                    var data = command.ExecuteReader();
                    while (data.Read())
                    {
                        var cliente = new Cliente()
                        {
                            apellidos = data["apellidos"].ToString(),
                            nombre = data["nombre"].ToString(),
                            correo = data["correo"].ToString(),
                            estado = data["estado"].ToString(),
                            fecha_registro = Convert.ToDateTime(data["fecha_registro"].ToString()),
                            id_cliente = Convert.ToInt32(data["id_cliente"].ToString())
                        };
                        listCliente.Add(cliente);
                    }
                }
                return listCliente;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message, ex.InnerException));
            }
        }
    }
}
