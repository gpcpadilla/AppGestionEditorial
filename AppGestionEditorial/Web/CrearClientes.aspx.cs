using AppGestionEditorial.Datos;
using AppGestionEditorial.Modelo;
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

            Clientes c = new Clientes( 
                                        txtid.Text,
                                        txtnombres.Text,
                                        txtapellidos.Text,
                                        txtdireccion.Text,
                                        txttelefono.Text,
                                        txtemail.Text
                                       );

            ClientesRepositorio datacliente = new ClientesRepositorio();

            datacliente.add(c);
        }

        }
    }

