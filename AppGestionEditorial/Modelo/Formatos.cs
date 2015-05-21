using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public abstract class Formatos 
    {
    #region "Atributos"
        private int codigo;        
        private string nombre;        
        private bool leer;        
        private bool guardar;
        private bool imprimir;
        private bool editar;
        private bool escuchar;
        private bool visualizar;
     
        #endregion

    #region "Propiedades"
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Leer
        {
            get { return leer; }
            set { leer = value; }
        }

         public bool Guardar
        {
            get { return guardar; }
            set { guardar = value; }
        }

        public bool Imprimir
        {
            get { return imprimir; }
            set { imprimir = value; }
        }

        public bool Editar
        {
            get { return editar; }
            set { editar = value; }
        }

        public bool Escuchar
        {
            get { return escuchar; }
            set { escuchar = value; }
        }

         public bool Visualizar
        {
            get { return visualizar; }
            set { visualizar = value; }
        }

       
        #endregion

    #region "Constructores"
        public Formatos()
        {
  
            this.codigo = 0000;
            this.nombre = "nombre";
            this.leer = true;
            this.guardar = true;
            this.imprimir = true;
            this.editar = true;
            this.escuchar = true;
            this.visualizar = true;
            
           
        }

        public Formatos(int codigo, string nombre, bool leer, bool guardar, bool imprimir, bool editar, bool escuchar, bool visualizar)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.leer = leer;
            this.guardar = guardar;
            this.imprimir = imprimir;
            this.editar = editar;
            this.escuchar = escuchar;
            this.visualizar = visualizar;
            
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "Nombre de la Clase" +
                "\n=============================================" +
                     "\nCodigo De La Factura  " + this.codigo +
                     "\nNombre  " + this.nombre +
                     "\nLeer: " + this.leer +
                     "\nGuardar: " + this.guardar +
                     "\nImprimir: " + this.imprimir +
                     "\nEditar: " + this.editar +
                     "\nEscuchar: " + this.escuchar +
                     "\nVisualizar: " + this.visualizar;
                     
        }

        public override bool Equals(object obj)
        {
            Formatos o = (Formatos)obj;
            bool result = false;

            if ((this.codigo == o.codigo) &&
                (this.nombre == o.nombre) &&
                (this.leer == o.leer) &&
                (this.guardar == o.guardar) &&
                (this.imprimir == o.imprimir) &&
                (this.editar == o.editar)&&
                (this.escuchar == o.escuchar) &&
                (this.visualizar == o.visualizar))

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