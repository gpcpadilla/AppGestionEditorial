﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Cientificos : Documentos
    {
    #region "Atributos"
                       
        private string tipos;
        
        #endregion

    #region "Propiedades"
        
        public string Tipos
        {
            get { return tipos; }
            set { tipos = value; }
        }
    
        #endregion

    #region "Constructores"
        public Cientificos()
            : base()
        {
            this.tipos= "tesis";
           
        }

        public Cientificos(int codigo, string titulo, string editorial, string edicion, string autores, string idiomas,
            string categorias, int numeropaginas, string fechaedicion, string fechapublicacion, string tipos)
            : base(codigo,titulo,editorial,edicion,autores,idiomas,categorias,numeropaginas,fechaedicion,fechapublicacion)
        {
            this.tipos = tipos;       
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return  "Nombre de la Clase" +
                "\n=============================================" +
                     
                     "\nTipos: " + this.tipos;
        }

        public override bool Equals(object obj)
        {
            Cientificos o = (Cientificos)obj;
            bool result = false;

            if 
                (this.tipos == o.tipos)

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