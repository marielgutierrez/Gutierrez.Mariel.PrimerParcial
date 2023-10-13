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
        protected int estreno;
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
        public int Estreno { get; set; }


        /// <summary>
        /// Propiedades
        /// </summary>
        public Pelicula()
        {
                
        }

        // Constructor que recibe un parámetro menos que el anterior
        public Pelicula(string titulo, int duracion, int estreno, string director, bool subtitulos)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.estreno = estreno;
        }
        public Pelicula(string titulo, int duracion, int estreno, string director)
        {
            this.titulo = titulo;
            this.estreno = estreno;
            this.duracion = duracion;
        }


        #region OPERADORES
        public static bool operator ==(Pelicula p1, Pelicula p2)
        {
            return p1.titulo == p2.titulo && p1.estreno == p2.estreno;
        }

        public static bool operator !=(Pelicula p1, Pelicula p2)
        {
            return !(p1 == p2);
        }

        //public static implicit operator()
        //{

        //}

        #endregion  

        #region SOBREESCRITURA EQUIVALENCIAS
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
            return (this.titulo,this.estreno).GetHashCode();
        }
        #endregion
        public override string ToString()
        {
            return $"{Titulo} ({Estreno})"; // Devuelve un formato de cadena representando la película
        }
    }
}
