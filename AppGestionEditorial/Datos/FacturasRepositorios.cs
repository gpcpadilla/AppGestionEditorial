﻿using System;
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
    public class FacturasRepositorios
    {
        #region Generar Factura
        private static List<Facturas> datac = new List<Facturas>();
        public List<Facturas> getFacturas()
        {
            // Creamos la lista genérica de Personas
            List<Facturas> lista = new List<Facturas>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/FacturasGuardadas.xml");

            XDocument doc = XDocument.Load(ruta);

            var facturasc = from f in doc.Descendants("Documentos") select f;

            foreach (XElement f in facturasc.Elements("Factura"))
            {
                Facturas factura = new Facturas(

                                                   int.Parse(f.Element("Id").Value),                                                  
                                                   f.Element("Fecha").Value,
                                                   f.Element("Sucursal").Value,
                                                   f.Element("Estado").Value
                                                   

                                               );
                lista.Add(factura);

            }


            return lista;
        }

        public void add(Facturas f)
        {
            datac.Add(f);
            WriteXML(datac);

        }

        private void WriteXML(List<Facturas> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/DocumentosXML/FacturasGuardadas.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Facturas f in list)
            {
                xmlwriter.WriteStartElement("Cliente");
                xmlwriter.WriteElementString("Fecha", f.Fecha);
                xmlwriter.WriteElementString("Estado", f.Estado);
                xmlwriter.WriteElementString("Sucursal", f.Sucursal);
                xmlwriter.WriteElementString("Id", f.Id.ToString());

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