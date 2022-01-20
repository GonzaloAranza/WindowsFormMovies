using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto
{
    [Serializable]
     class Sistema
    {
        private List<Usuario> Usuarios = new List<Usuario>();
        private administrador admin;
        private List<Movie> peliculas = new List<Movie>();

        public Sistema()
        {
            admin = new administrador("admin","admin");
        }

       
        //Médotos para crear usuario
        public bool Chequeo(string usuario, string contraseña)
        {
            if (usuario == "admin")
                return false;

            for (int i = 0; i < Usuarios.Count; i++)
                if (Usuarios[i].CheckUsuario(usuario))
                    return false;


              AñadirUsuario(new Usuario(usuario, contraseña));
            return true;
        }
        private void AñadirUsuario(Usuario U)
        {
            Usuarios.Add(U);
        }

        //login
        public bool EsAdmin(string nombre, string contraseña)
        {
            if (admin.Coincidencia(nombre, contraseña))
                return true;

            return false;

        }

        public bool EsUsuario(string usuario, string contraseña)
        {


            foreach(Usuario U in Usuarios)
            {
                if (U.Coincidencia(usuario, contraseña))
                    return true;
            }

            return false;

        }

     
        //iniciar form admin

        public int  Totalpeliculas(int n)
        {
            return n = peliculas.Count;
        }

        public string [] DatosPelis(string[] S,int n)
        {
            //no me gusta tener que escribir el subindice del dato
            S[0] = peliculas[n].Getnombre();
            S[1] = peliculas[n].Getfecha();
            S[2] = peliculas[n].Getdirector();
            S[3] = peliculas[n].Getgenero();
            S[4] = peliculas[n].Getclasificacion();
           

            return S;
        }

        //pedir referencia a pelicula. No lo usé.
        public Movie RetornarRefPelicula(int n)
        {
            return peliculas[n];
        }


        //Métodos para Admin
        public bool ChequeoPeliculas(string nom,string fecha,string director, string género, string clasificacion, string sinopsis)
        {
            foreach (Movie M in peliculas)
                if (M.chequeo(nom, fecha, director, género, clasificacion))
                    return false;


            AñadirPelicula(nom, fecha, director, género, clasificacion, sinopsis);
            return true;
        }
        private void AñadirPelicula(string nom, string fecha, string director, string género, string clasificacion, string sinopsis)
        {
            peliculas.Add(new Movie(nom, fecha, director, género, clasificacion,sinopsis));            
        }

        public void BorrarPeli(int n)
        {
            peliculas.RemoveAt(n);
        }

             
        
       
     }     
      
}
