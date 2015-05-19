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
        ///<summary>
        ///Contructor de inicialización Cuentas
        ///</summary>
        ///<param name="nombre">Nombre del Cliente</param>
        ///<param name="cliente">Numero de cuenta del Cliente</param>
        ///<param name="id">Numero de cedula del Cliente</param>
        ///<param name="monto">Balance actual del Cliente  </param>
        ///
        public Documentos(int codigo , string identificacion, string idcliente, double balance)
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
                     "\nNombre:  " + this.cliente  +
                     "\nNum Cuenta:  " + this.identificacion  +
                     "\nIdentificacion Cliente: " + this.idcliente  +
                     "\nBalance Actual: " + this.balance;
        }

        public override bool Equals(object obj)
        {
            Cuentas o = (Cuentas)obj;
            bool result = false;

            if ((this.cliente == o.cliente) &&
                (this.identificacion == o.identificacion) &&
                (this.idcliente == o.idcliente) &&
                (this.balance == o.balance))

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