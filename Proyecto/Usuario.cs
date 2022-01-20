using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable]
     class Usuario
    {
        private string Nombre;
        private string Contraseña;

       public Usuario(string nom, string contraseña)
        {
            this.Nombre = nom;
            this.Contraseña = contraseña;
        }

        public bool CheckUsuario (string U)
        {
            if (string.Compare(U, Nombre) == 0)
                return true;

            return false;
        }

        public string DevolverDatos(string Datos)
        {
            Datos = "Nombre: " + Nombre + "\t" + "Contraseña: " + Contraseña +"\n" ;

            return Datos;

        }

        public bool Coincidencia (string nombre , string contraseña)
        {
            if (Nombre == nombre && Contraseña == contraseña)
                return true;

            return false;
        }
     
    }


}
