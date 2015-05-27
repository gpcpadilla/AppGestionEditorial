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
    public partial class Facturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {


            
                int id = int.Parse(txtid.Text);
                
                Facturas f = new Facturas(
                                            id,
                                            txtfecha.Text,
                                            txtsucursal.Text,
                                            txtestado.Text
      

                                           );

                FacturasRepositorios dataf = new FacturasRepositorios();

                dataf.add(f);
            }
        
        }
    }
