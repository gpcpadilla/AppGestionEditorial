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
namespace AppGestionEditorial.DocumentosXML
{
    public class RevistasRepositorios
    {
        #region Guardar Revistas
        private static List<Revistas> datab = new List<Revistas>();
        public List<Revistas> getRevistas()
        {
            // Creamos la lista genérica de Personas
            List<Revistas> lista = new List<Revistas>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/RevistasRepositorios.xml");

            XDocument doc = XDocument.Load(ruta);

            var revistac = from r in doc.Descendants("Documentos") select r;

            foreach (XElement r in revistac.Elements("Revistas"))
            {
                Revistas revista = new Revistas(

                                                   int.Parse(r.Element("Codigo").Value),
                                                   r.Element("Titulo").Value,
                                                   r.Element("Editoria").Value,
                                                   r.Element("Edicion").Value,
                                                   r.Element("Autores").Value,
                                                   r.Element("Idiomas").Value,
                                                    r.Element("Categorias").Value,
                                                   int.Parse(r.Element("Numero De Paginas").Value),
                                                   r.Element("Fecha De Edicion").Value,
                                                   r.Element("Fecha De Publicaion").Value,
                                                   int.Parse(r.Element("Numero De Articulos").Value),                                                                                                
                                                   int.Parse(r.Element("Numero De Volumenes").Value)
                                                   
                                                  
                                                  
                                                   
                                                   
                                               );
                lista.Add(revista);

            }


            return lista;
        }

        public void add(Revistas r)
        {
            datab.Add(r);
            WriteXML(datab);

        }

        private void WriteXML(List<Revistas> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/DocumentosXML/RevistasRepositorios.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Revistas r in list)
            {
                xmlwriter.WriteStartElement("Revistas");
                xmlwriter.WriteElementString("Titulos Del Documento", r.TituloDelLibro);
                xmlwriter.WriteElementString("Edicion", r.Edicion);
                xmlwriter.WriteElementString("Editorial", r.Editorial);
                xmlwriter.WriteElementString("Fecha De Publicacion", r.FechaPublicacion);
                xmlwriter.WriteElementString("Fecha De Edicion", r.FechaEdicion);
                xmlwriter.WriteElementString("Autores", r.Autores);
                xmlwriter.WriteElementString("Idiomas", r.Idiomas);
                xmlwriter.WriteElementString("codigo", r.Codigo.ToString());
                xmlwriter.WriteElementString("Numero De Paginas", r.NumeroPaginas.ToString());
                xmlwriter.WriteElementString("Categorias", r.Categorias.ToString());
                xmlwriter.WriteElementString("Numero De Articulos", r.NumeroArticulos.ToString());
                xmlwriter.WriteElementString("Numero De Volumenes", r.NumeroVolumenes.ToString());
                xmlwriter.WriteEndElement();
            }

            xmlwriter.WriteEndElement();

            //End XML Document
            xmlwriter.WriteEndDocument();

            //Close Write
            xmlwriter.Close();
        }

        #endregion
    }
}