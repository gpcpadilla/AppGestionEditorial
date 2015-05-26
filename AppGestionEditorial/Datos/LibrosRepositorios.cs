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
    public class LibrosRepositorios
    {
        #region Guardar Libros
        private static List<Libros> data = new List<Libros>();
        public List<Libros> getLibros()
        {
            // Creamos la lista genérica de Personas
            List<Libros> lista = new List<Libros>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/LibrosRepositorios.xml");

            XDocument doc = XDocument.Load(ruta);

            var librosc = from c in doc.Descendants("Documentos") select c;

            foreach (XElement c in librosc.Elements("Libros"))
            {
                Libros libro = new Libros(
                                                                                                                   
                                                   int.Parse(c.Element("Codigo").Value),
                                                   int.Parse(c.Element("Numero De Paginas").Value),
                                                   int.Parse(c.Element("Categorias").Value),
                                                   int.Parse(c.Element("Numero De Tomos").Value),
                                                   int.Parse(c.Element("Numero De Capitulos").Value),
                                                   c.Element("Nivel").Value,
                                                   c.Element("Titulo").Value,
                                                   c.Element("Editoria").Value,
                                                   c.Element("Edicion").Value,
                                                   c.Element("Autores").Value,
                                                   c.Element("Idiomas").Value,
                                                   c.Element("Fecha De Publicaion").Value,
                                                   c.Element("Fecha De Edicion").Value
                                               );
                lista.Add(libro);

            }


            return lista;
        }

        public void add(Libros c)
        {
            data.Add(c);
            WriteXML(data);

        }

        private void WriteXML(List<Libros> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/DocumentosXML/LibrosRepositorios.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Libros c in list)
            {
                xmlwriter.WriteStartElement("Libros");
                xmlwriter.WriteElementString("Titulo Del Documento", c.TituloDelLibro);
                xmlwriter.WriteElementString("Edicion", c.Edicion);
                xmlwriter.WriteElementString("Editorial", c.Editorial);
                xmlwriter.WriteElementString("Fecha De Publicaion", c.FechaPublicacion);
                xmlwriter.WriteElementString("Fecha De Edicion", c.FechaEdicion);
                xmlwriter.WriteElementString("Autores", c.Autores);
                xmlwriter.WriteElementString("Idiomas", c.Idiomas);
                xmlwriter.WriteElementString("Nivel", c.Nivel);
                xmlwriter.WriteElementString("Balance", c.Codigo.ToString());
                xmlwriter.WriteElementString("tasadeinteres", c.NumeroPaginas.ToString());
                xmlwriter.WriteElementString("Balance", c.Categorias.ToString());
                xmlwriter.WriteElementString("tasadeinteres", c.NumeroTomos.ToString());
                xmlwriter.WriteElementString("Balance", c.NumeroCapitulos.ToString());
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