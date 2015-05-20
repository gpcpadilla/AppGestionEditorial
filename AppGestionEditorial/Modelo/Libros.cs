using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Libros : Documentos
    {
    #region "Atributos"
                
        private string genero;        
        private string biografia;
        private string glosario;
        #endregion

    #region "Propiedades"
        
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

         public string Biografia
        {
            get { return biografia; }
            set { biografia = value; }
        }

         public string Glosario
         {
             get { return glosario; }
             set { glosario = value; }
         }
       
        
        #endregion

    #region "Constructores"
        public Libros()
        {
           
        }
       
        public Libros(int codigo , string nombre, string editorial, string  edicion, string autor, string genero,
            string biografia, string glosario)
        {
            this.genero = genero;
            this.biografia = biografia;
            this.glosario = glosario;
            
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return  "Nombre de la Clase" +
                "\n=============================================" +
                     "\nGenero Del Libro  " + this.genero  +
                     "\nBiografia Del Libro  " + this.biografia  +
                     "\nGlosario Del Libro: " + this.glosario;
        }

        public override bool Equals(object obj)
        {
            Libros o = (Libros)obj;
            bool result = false;

            if ((this.genero == o.genero) &&
                (this.biografia == o.biografia) &&
                (this.glosario == o.glosario))

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