using AppGestionEditorial.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppGestionEditorial.Web
{
    public partial class Facturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {


            {
                int id = int.Parse(txtid.Text);
                
                Facturas c = new Facturas(
                                            txtestado.Text,
                                            txtsucursal.Text,
                                            txtfecha.Text,
                                            id


                                           );



                FacturasRepositorios data = new FacturasRepositorios();

                data.add(c);
            }
        }
    }
}