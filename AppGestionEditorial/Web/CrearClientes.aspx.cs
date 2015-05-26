using AppGestionEditorial.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppGestionEditorial.Web
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           

            {
                int identificacion = int.Parse(txtid.Text);
                int telefono = int.Parse(txttelefono.Text);
                Clientes c = new Clientes(
                                            txtnombres.Text,
                                            txtapellidos.Text,
                                            txtemail.Text,
                                            telefono,
                                            identificacion


                                           );



                ClientesRepositorio data = new ClientesRepositorio();

                data.add(c);
            }
        }
    }
}