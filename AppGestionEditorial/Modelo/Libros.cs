using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Libros : Documentos
    {
    #region "Atributos"
                
        private int numerotomos;        
        private int numerocapitulos;
        private string nivel;
        
        #endregion

    #region "Propiedades"
        
        public int NumeroTomos
        {
            get { return numerotomos; }
            set { numerotomos = value; }
        }

         public int NumeroCapitulos
        {
            get { return numerocapitulos; }
            set { numerocapitulos = value; }
        }

         public string Nivel
         {
             get { return nivel; }
             set { nivel = value; }
         }
       
        
        #endregion

    #region "Constructores"
        public Libros()
            :base()
        {
            this.numerotomos = 0000;
            this.numerocapitulos = 12;
            this.nivel = "4";
        }

        public Libros(int codigo, string titulo, string editorial, string edicion, string autores, string idiomas,
            string categorias, int numeropaginas, string fechaedicion, string fechapublicacion, 
            int numerotomos, int numerocapitulos, string nivel)
            : base(codigo, titulo, editorial, edicion, autores, idiomas, categorias, numeropaginas, fechaedicion, fechapublicacion)
        {
            this.numerotomos = numerotomos;
            this.numerocapitulos = numerocapitulos;
            this.nivel = nivel;
            
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return  "Nombre de la Clase" +
                "\n=============================================" +
                     "\nNumero De tomos  " + this.numerotomos  +
                     "\nNumeros De capitulos  " + this.numerocapitulos  +
                     "\nNivel: " + this.nivel;
        }

        public override bool Equals(object obj)
        {
            Libros o = (Libros)obj;
            bool result = false;

            if ((this.numerotomos == o.numerotomos) &&
                (this.numerocapitulos == o.numerocapitulos) &&
                (this.nivel == o.nivel))

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