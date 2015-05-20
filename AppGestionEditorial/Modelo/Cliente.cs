﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Cliente 
    {
    #region "Atributos"
        private int id;        
        private string nombres;        
        private string apellidos;
        private string direccion ;        
        private int telefono ;
        private string email;
     
        #endregion

    #region "Propiedades"
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

         public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        #endregion

    #region "Constructores"
        public Cliente()
        {
            ///<summary>
            ///Contructor de Cuentas
            ///</summary>
            this.id = 0000;
            this.nombres = "nombre";
            this.apellidos = "apellidos";
            this.direccion = "direccion";
            this.telefono = 300604854;
            this.email = "email@hotmail.com";

        }

        public Cliente(int id, string nombres, string apellidos, string direccion, int telefono, string email)
        {
            this.id = Id;
            this.nombres = Nombres;
            this.apellidos = Apellidos;
            this.direccion = Direccion;
            this.telefono = Telefono;
            this.email = Email;
            
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "Nombre de la Clase" +
                "\n=============================================" +
                     "\nId  " + this.id+
                     "\nNombres  " + this.nombres +
                     "\nApellidos: " + this.apellidos +
                     "\nDireccion: " + this.direccion +
                     "\nTelefono: " + this.telefono +
                     "\nEmail: " + this.email;
                     
        }

        public override bool Equals(object obj)
        {
            Cliente o = (Cliente)obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.nombres == o.nombres) &&
                (this.apellidos == o.apellidos) &&
                (this.direccion == o.direccion) &&
                (this.telefono == o.telefono) &&
                (this.email == o.email))

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