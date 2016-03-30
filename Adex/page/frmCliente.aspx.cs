using System;
using Adex.Negocio.logica;
using Adex.Entidad.Models;
using System.Web.UI.WebControls;

namespace Adex.page
{
    public partial class frmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // var cliente = new Cliente() { apellidos = "Choque Rojas", nombre = "Noé David", correo = "david.choque@metricaandina.com", estado = "A", fecha_registro = DateTime.Now };
            //var response = new NCliente().save(cliente);
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            gv_cliente.DataSource = new NCliente().list();
            gv_cliente.DataBind();
        }

        protected void gv_cliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Capturamos el index que se ha seleccionado
            var index = Convert.ToInt32(e.CommandArgument);
            // Creamos una fila de un datagrid y le asignamos el indice
            GridViewRow row = gv_cliente.Rows[index];
            // Creamos un nuevo listItem para almacenar todos los datos del registro seleccionado.     

            //Selección de registro
            if (e.CommandName == "SelParaSQL")
            {
                var id = gv_cliente.DataKeys[index].Value;
                var apellidos = gv_cliente.Rows[index].Cells[2].Text.ToString();
            }
        }
    }
}