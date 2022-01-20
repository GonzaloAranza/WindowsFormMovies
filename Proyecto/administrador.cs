using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable]
    class administrador 
    {
        private string Nombre;
        private string Contraseña;
        public administrador(string nom, string contraseña) 
        {
            Nombre = nom;
            Contraseña = contraseña;
        }

        public bool Coincidencia(string nombre, string contraseña)
        {
            if (Nombre == nombre && Contraseña == contraseña)
                return true;

            return false;
        }

        public string DevolverDatos(ref string Datos)
        {
            Datos = "Nombre: " + Nombre + "\t" + "Contraseña: " + Contraseña + "\n";


            return Datos;
        }
    }
}
