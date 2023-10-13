using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Pelicula
    {
        protected string titulo;
        protected int duracion;
        protected string año;
        protected string director;
        protected bool subtitulos;


        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }
        //public string Titulo { get; set; }
        public int Duracion { get; set; }
        public int Año { get; set; }


        /// <summary>
        /// Propiedades
        /// </summary>
        public Pelicula()
        {
                
        }

        // Constructor que recibe un parámetro menos que el anterior
        public Pelicula(string titulo, int duracion, int año, string director, bool subtitulos)
        {
            Titulo = titulo;
            Duracion = duracion;
            Año = año;
        }
        public Pelicula(string titulo, int duracion, int año, string director)
        {
            Titulo = titulo;
            Año = año;
            Duracion = duracion;
        }


        public static bool operator ==(Pelicula p1, Pelicula p2)
        {
            return p1.titulo == p2.titulo;
        }

        public static bool operator !=(Pelicula p1, Pelicula p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false; // es mejor crear una variable antes de devolver dos return

            if (obj is Pelicula)
            {
                retorno = this == (Pelicula)obj;
            }
            return retorno;
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



        public override string ToString()
        {
            return $"{Titulo} ({Año})"; // Devuelve un formato de cadena representando la película
        }
    }
}
