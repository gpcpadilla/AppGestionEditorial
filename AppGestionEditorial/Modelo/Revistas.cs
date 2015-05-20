using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Revistas : Documentos
    {
    #region "Atributos"
                
        private string avisospublicitarios;        
        private string articulos;
        private string tess;

        #endregion

    #region "Propiedades"
        
        public string AvisosPublicitarios
        {
            get { return avisospublicitarios; }
            set { avisospublicitarios = value; }
        }

         public string Artuculos
        {
            get { return articulos; }
            set { articulos = value; }
        }

         public string Tess
         {
             get { return tess; }
             set { tess = value; }
         }
       
        
        #endregion

    #region "Constructores"
        public Revistas()
        {
           
        }

        public Revistas(int codigo, string nombre, string editorial, string edicion, string autor, string avisospublicitarios,
            string articulos, string tess)
        {
            this.avisospublicitarios = avisospublicitarios;
            this.articulos = articulos;
            this.tess = tess;
            
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return  "Nombre de la Clase" +
                "\n=============================================" +
                     "\nAvisos Publicitarios " + this.avisospublicitarios +
                     "\nArticulos " + this.articulos  +
                     "\nTess: " + this.tess;
        }

        public override bool Equals(object obj)
        {
            Revistas o = (Revistas)obj;
            bool result = false;

            if ((this.avisospublicitarios == o.avisospublicitarios) &&
                (this.articulos == o.articulos) &&
                (this.tess == o.tess))

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