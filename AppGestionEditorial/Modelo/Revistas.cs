using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Revistas : Documentos
    {
    #region "Atributos"
                   
        private int numeroarticulos;
        private int numerovolumenes;

        #endregion

    #region "Propiedades"
        
        public int NumeroArticulos
        {
            get { return numeroarticulos; }
            set { numeroarticulos = value; }
        }

         public int NumeroVolumenes
        {
            get { return numerovolumenes; }
            set { numerovolumenes = value; }
        }

        
        #endregion

    #region "Constructores"
        public Revistas()
        {
            this.numeroarticulos = 2;
            this.numerovolumenes = 4;
           
        }

        public Revistas(int codigo, string titulo, string editorial, string edicion, string autores, string idiomas,
            string categorias, int numeropaginas, DateTime fechaedicion, DateTime fechapublicacion, int numeroarticulos, int numerovolumenes)
        {
            this.numerovolumenes = numerovolumenes;
            this.numeroarticulos = numeroarticulos;
           
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return  "Nombre de la Clase" +
                "\n=============================================" +
                    "\nNumero De Articulos " + this.numeroarticulos  +
                     "\nNumero De Volumenes: " + this.numerovolumenes;
        }

        public override bool Equals(object obj)
        {
            Revistas o = (Revistas)obj;
            bool result = false;

            if ((this.numeroarticulos == o.numeroarticulos) &&
                (this.numerovolumenes == o.numerovolumenes))

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