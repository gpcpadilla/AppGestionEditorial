using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Documentos {
    #region "Atributos"
        private int codigo;        
        private string nombre;        
        private string editorial;        
        private string edicion;
        private string  autor;
        #endregion

    #region "Propiedades"
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NombreDelLibro
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

         public string Edicion
        {
            get { return edicion; }
            set { edicion = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        #endregion

    #region "Constructores"
        public Documentos()
        {
            ///<summary>
            ///Contructor de Cuentas
            ///</summary>
            this.codigo = 0000;
            this.nombre = "Nombre Del Libro";
            this.editorial = "Editorial";
            this.edicion = "Edicion Del Libro";
            this.autor = "Autor";
           
        }
       
        public Documentos(int codigo , string nombre, string editorial, string  edicion, string autor)
        {
            this.codigo = Codigo;
            this.nombre = NombreDelLibro;
            this.editorial = Editorial;
            this.edicion = Edicion;
            this.autor = Autor;
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return  "Nombre de la Clase" +
                "\n=============================================" +
                     "\nCodigo Del Libro  " + this.codigo  +
                     "\nNombre Del Libro  " + this.nombre  +
                     "\nEditorial Del Libro: " + this.editorial  +
                     "\nEdicion Del Libro: " + this.edicion +
                     "\nAutor: " + this.autor;
        }

        public override bool Equals(object obj)
        {
            Documentos o = (Documentos)obj;
            bool result = false;

            if ((this.codigo == o.codigo) &&
                (this.nombre == o.nombre) &&
                (this.editorial == o.editorial) &&
                (this.edicion == o.edicion) &&
                (this.autor == o.autor))

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