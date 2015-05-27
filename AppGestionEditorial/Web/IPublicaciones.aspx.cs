using AppGestionEditorial.Datos;
using AppGestionEditorial.Modelo;
using AppGestionEditorial.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml;
using System.Xml.Linq;

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
            int numerodepaginas = int.Parse(txtnumeropaginas.Text);

            string shipping_type = type.SelectedItem.Value;

            #region"Libros"
            if (shipping_type == "Libros")
            {
                
                int numerotomos = int.Parse(txtnumerotomos.Text);
                 int nuemrocapitulos = int.Parse(txtnumerotomos.Text);
          
                Libros c = new Libros(

                                            codigo,numerodepaginas,
                                            txtcategorias.Text,
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

                LibrosRepositorios datac = new LibrosRepositorios();

                datac.add(c);
            }
                #endregion

            #region "Revistas"
            if (shipping_type == "Revistas")
            {

                Revistas r = new Revistas(
                     int numerodearticulos = int.Parse(txtnumeroarticulos.Text);
                     int numerodevolumenes = int.Parse(txtnumerovolumenes.Text);

                                            codigo, numerodepaginas, categorias,
                                            txtedicion.Text,
                                            txttitulo.Text,
                                            txteditorial.Text,
                                            txtautores.Text,
                                            txtidiomas.Text,
                                            txtfechaedicion.Text,
                                            txtfechapublicacion.Text,
                                            numerodearticulos,numerodevolumenes

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
                                            
                                            codigo,numerodepaginas,
                                            txtcategorias.Text,
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
            
        
   
