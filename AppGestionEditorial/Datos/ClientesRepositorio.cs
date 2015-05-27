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

namespace AppGestionEditorial.Datos
{
    public class ClientesRepositorio
    {
        #region Registrar Clientes
        private static List<Clientes> datacliente = new List<Clientes>();

        public List<Clientes> getPersona()
        {
            // Creamos la lista genérica de Personas
            List<Clientes> lista = new List<Clientes>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/Clientesregistrados.xml");

            XDocument doc = XDocument.Load(ruta);

            var people = from c in doc.Descendants("Documentos") select c;

            foreach (XElement c in people.Elements("Clientes"))
            {
                Clientes cliente = new Clientes(


                                                   int.Parse(c.Element("Id").Value),
                                                   c.Element("Nombres").Value,
                                                   c.Element("Apellidos").Value,
                                                   c.Element("Direccion").Value,
                                                   int.Parse(c.Element("Telefono").Value),
                                                   c.Element("Email").Value


                                               );
                lista.Add(cliente);

            }


            return lista;
        }

        public void add(Clientes c)
        {
            datacliente.Add(c);
            WriteXML(datacliente);

        }

        private void WriteXML(List<Clientes> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("DocumentosXML/Clientesregistrados.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Clientes c in list)
            {
                xmlwriter.WriteStartElement("Cliente");
                xmlwriter.WriteElementString("Nombres", c.Nombres);
                xmlwriter.WriteElementString("Apellidos", c.Apellidos);
                xmlwriter.WriteElementString("Direccion", c.Direccion);
                xmlwriter.WriteElementString("Email", c.Email);
                xmlwriter.WriteElementString("Id", c.Id.ToString());
                xmlwriter.WriteElementString("Telefono", c.Telefono.ToString());
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