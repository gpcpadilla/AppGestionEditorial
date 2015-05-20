using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Documentos {
    #region "Atributos"
        private int codigo;        
        private string titulo;        
        private string editorial;        
        private string edicion;
        private string  autores;
        private string idiomas;
        private string categorias;
        private int numeropaginas;
        private DateTime fechaedicion ;
        private DateTime fechapublicacion;
        
        #endregion

    #region "Propiedades"
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string TituloDelLibro
        {
            get { return titulo; }
            set { titulo = value; }
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

        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }

        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }

        public string Categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }

        public int NumeroPaginas
        {
            get { return numeropaginas; }
            set { numeropaginas = value; }
        }

        public DateTime FechaEdicion
        {
            get { return fechaedicion; }
            set {  fechaedicion  = value; }
        }

        public DateTime FechaPublicacion
        {
            get { return fechapublicacion; }
            set { fechapublicacion = value; }
        }
        #endregion

    #region "Constructores"
        public Documentos()
        {
            ///<summary>
            ///Contructor de Cuentas
            ///</summary>
            this.codigo = 0000;
            this.titulo = "Titulo Del Libro";
            this.editorial = "Editorial";
            this.edicion = "Edicion Del Libro";
            this.autores = "Autores";
            this.idiomas = "Idiomas";
            this.editorial = "Categorias";
            this.edicion = "Numero De Paginas";
            this.autores = "Fecha De Edicion";
            this.idiomas = "Fecha De Publicacion";
           
        }
       
        public Documentos(int codigo , string titulo, string editorial, string  edicion, string autores, string idiomas,
            string categorias, int numeropaginas, DateTime fechaedicion, DateTime fechapublicacion)
        {
            this.codigo = Codigo;
            this.titulo = TituloDelLibro;
            this.editorial = Editorial;
            this.edicion = Edicion;
            this.autores = Autores;
            this.idiomas = Idiomas;
            this.categorias = Categorias;
            this.numeropaginas = NumeroPaginas;
            this.fechaedicion = FechaEdicion;
            this.fechapublicacion = FechaPublicacion;
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "Nombre de la Clase" +
                "\n=============================================" +
                     "\nCodigo Del Libro  " + this.codigo +
                     "\nTitulo Del Libro  " + this.titulo +
                     "\nEditorial Del Libro: " + this.editorial +
                     "\nEdicion Del Libro: " + this.edicion +
                     "\nAutores: " + this.autores +
                     "\nIdiomas: " + this.idiomas +
                     "\nCategorias: " + this.categorias +
                     "\nNumero De Paginas: " + this.numeropaginas +
                     "\nFecha De Edicion: " + this.fechaedicion +
                     "\nFecha De Publicacion: " + this.fechapublicacion;
        }

        public override bool Equals(object obj)
        {
            Documentos o = (Documentos)obj;
            bool result = false;

            if ((this.codigo == o.codigo) &&
                (this.titulo == o.titulo) &&
                (this.editorial == o.editorial) &&
                (this.edicion == o.edicion) &&
                (this.autores == o.autores) &&
                (this.idiomas == o.idiomas)&&
                (this.categorias == o.categorias) &&
                (this.numeropaginas == o.numeropaginas) &&
                (this.fechaedicion == o.fechaedicion) &&
                (this.fechapublicacion == o.fechapublicacion))

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