﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Factura
    {
    #region "Atributos"
        private int id;        
        private DateTime fecha;        
        private string sucursal;
        private string estado;        
             
        #endregion

    #region "Propiedades"
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

         public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

              
        #endregion

    #region "Constructores"
        public Factura()
        {
        
            this.id = 0000;
            this.fecha = fecha.Date;
            this.sucursal = "cartagena";
            this.estado = "pagado"; 

        }

        public Factura(int id, DateTime fecha, string sucursal, string estado)
        {
            this.id = id;
            this.fecha = fecha;
            this.sucursal = sucursal;
            this.estado = estado;
            
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "Nombre de la Clase" +
                "\n=============================================" +
                     "\nId  " + this.id+
                     "\nFecha De Pago  " + this.fecha +
                     "\nSucursal: " + this.sucursal +
                     "\nEstado: " + this.estado;
                     
        }

        public override bool Equals(object obj)
        {
            Factura o = (Factura)obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.fecha == o.fecha) &&
                (this.sucursal == o.sucursal) &&
                (this.estado == o.estado))

                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
    }
}