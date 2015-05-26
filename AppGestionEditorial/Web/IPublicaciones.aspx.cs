using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppGestionEditorial.Modelo;
using AppGestionEditorial.Datos;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;
using AppGestionEditorial.Web;

namespace AppGestionEditorial.Web
{
    public partial class IPublicaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtcodigo.Text);
            int categorias = int.Parse(txtcategorias.Text);
            int numerodepaginas = int.Parse(txtnumeropaginas.Text);

            string shipping_type = type.SelectedItem.Value;

            #region"Libros"
            if (shipping_type == "Libros")
            {
                
                int numerotomos = int.Parse(txtnumerotomos.Text);
                 int nuemrocapitulos = int.Parse(txtnumerotomos.Text);
                

                Libros c = new Libros(

                                            codigo,numerodepaginas,categorias,
                                            txtedicion.Text,
                                            txttitulo.Text,
                                            txteditorial.Text,
                                            txtautores.Text,
                                            txtidiomas.Text,
                                            txtfechaedicion.Text,
                                            txtfechapublicacion.Text,
                                            txtnivel.Text,
                                            numerotomos,nuemrocapitulos
                                            
                                           );



                LibrosRepositorios data = new LibrosRepositorios();

                data.add(c);
            }
                #endregion

            #region "Revistas"
            if (shipping_type == "Revistas")
            {

                Revistas r = new Revistas(
                     int numeroarticulos = int.Parse(txtnumeroarticulos.Text);
                     int numerovolumenes = int.Parse(txtnumerovolumenes.Text);

                                            codigo, numerodepaginas, categorias,
                                            txtedicion.Text,
                                            txttitulo.Text,
                                            txteditorial.Text,
                                            txtautores.Text,
                                            txtidiomas.Text,
                                            txtfechaedicion.Text,
                                            txtfechapublicacion.Text,
                                            numeroarticulos,numerovolumenes

                                           );



                ResvistasRepositorios meta = new ResvistasRepositorios();

                meta.add(r);
            }
#endregion

            #region "Cientificos"
            if (shipping_type == "Cientificos")
            {
                 int tipos = int.Parse(txttipos.Text);
                Cientificos ci = new Cientificos(
                                            
                                            codigo,numerodepaginas,categorias,
                                            txtedicion.Text,
                                            txttitulo.Text,
                                            txteditorial.Text,
                                            txtautores.Text,
                                            txtidiomas.Text,
                                            txtfechaedicion.Text,
                                            txtfechapublicacion.Text,
                                            tipos


                                           );



                CientificosRepositorios lugar = new CientificosRepositorios();

                lugar.add(ci);
            #endregion
            }
        }
    }
}