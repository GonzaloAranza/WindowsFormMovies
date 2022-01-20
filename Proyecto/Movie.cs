using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable]

    class Movie
    {        
        private string nombre;
        private string fecha;
        private string director;
        private string genero;
        private string clasificacion;
        private List<String> comentarios = new List<String>();
        private string sinopsis;


        public Movie(string nom, string fecha, string director, string genero, string clasificacion, string sinops)
        {
            this.nombre = nom;
            this.fecha = fecha;
            this.director = director;
            this.genero = genero;
            this.clasificacion = clasificacion;
            this.sinopsis = sinops;
        }

        public bool chequeo(string nom, string fecha, string director, string genero, string clasificacion)
        {
            if (nombre == nom && this.fecha == fecha && this.director == director && this.genero == genero && this.clasificacion == clasificacion)
                return true;

            return false;
        }

        public string [] RetornarDatos(string[] S)
        {
            S[0] = nombre;
            S[1] = fecha;
            S[2] = director;
            S[3] = genero;
            S[4] = clasificacion;

            return S;
        }
        public string Getnombre()
        {
            return nombre;
        }
        public string Getfecha()
        {
            return fecha;
        }
        public string Getdirector()
        {
            return director;
        }
       
        public string Getgenero()
        {
            return genero;
        }
        public string Getclasificacion()
        {
            return nombre;
        }
        public string Getsinopsis()
        {
            return nombre;
        }
        public List<string> Getlist()
        {
            return comentarios;
        }
        public void AgregarComentario(string S)
        {
            comentarios.Add(S);
        }
    }
}
