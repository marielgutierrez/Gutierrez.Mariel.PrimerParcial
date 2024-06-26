﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase base que maneja los atributos principales de una pelicula:
    /// titulo, año de estreno, director y nacionalidad.
    /// </summary>
    [XmlInclude(typeof(Entidades.PeliculaAccion))]
    [XmlInclude(typeof(Entidades.PeliculaTerror))]
    [XmlInclude(typeof(Entidades.PeliculaComedia))]
    public abstract class Pelicula : Object
    {
        protected string titulo;
        protected int estreno;
        protected string director;
        protected ENacionalidad nacionalidad;

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public int Estreno
        {
            get { return this.estreno; }
            set { this.estreno = value; }
        }

        public string Director     
        {
            get { return this.director; }
            set { this.director = value; }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// inicializa los atributos con los valores traidos por parametro
        /// </summary>
        /// <param name="titulo"> titulo de la pelicula</param>
        /// <param name="estreno"> año creado la pelicula</param>
        /// <param name="director"> director de la pelicula </param>
        /// <param name="nacionalidad"> origen de la pelicula</param>
        public Pelicula(string titulo, int estreno, string director, ENacionalidad nacionalidad)
        {
            this.titulo = titulo;
            this.estreno = estreno;
            this.director = director;
            this.nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Permite crear una película de acción especificando el título, año de estreno y
        /// director. Por defecto, la nacionalidad se establece como Argentina.
        /// </summary>
        /// <param name="titulo">titulo de la pelicula</param>
        /// <param name="estreno">estreno de la pelicula</param>
        /// <param name="director">director de la pelicula</param>
        public Pelicula(string titulo, int estreno, string director)
         : this(titulo, estreno, director, ENacionalidad.Argentina)
        {
            
        }
        /// <summary>
        /// inicializa los atributos con valores predeterminados
        /// </summary>
        public Pelicula()
        {
            this.titulo = "SIN TITULO";
            this.estreno = 0;
            this.director = "SIN DIRECTOR";
            this.nacionalidad = ENacionalidad.Desconocida;
        }

        #region METODOS VIRTUAL Y ABSTRACT
        /// <summary>
        /// Se encarga de mostrar en una cadena de texto con los valores de los atributos
        /// principales de una pelicula.
        /// </summary>
        /// <returns>informacion de la pelicula</returns>
        protected virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: "+this.titulo);
            sb.AppendLine($"Estreno: "+this.estreno.ToString());
            sb.AppendLine($"Director: "+this.director);
            sb.AppendLine($"Nacionalidad: "+this.nacionalidad);

            return sb.ToString();
        }
        /// <summary>
        /// Utiliza el método MostrarInformacion para generar la representación de la película.
        /// </summary>
        /// <returns>Una cadena que representa la información detallada de la película.</returns>
        public override string ToString()
        {
            return this.MostrarInformacion(); 
        }
        /// <summary>
        /// Se determina su uso en las clases derivadas.
        /// </summary>
        public abstract void ClasificarPelicula();
        #endregion

        #region METODOS SOBRECARGADOS
        /// <summary>
        /// Muestra el titulo y una duracion random de la pelicula
        /// </summary>
        public void Reproducir()
        {
            Random random = new Random();

            int duracion = random.Next(90, 141);

            Console.WriteLine($"Reproduciendo {this.titulo} - Duración: {duracion} minutos");
        }

        /// <summary>
        /// utiliza el metodo Reproducir() y
        /// ademas se muestra si contiene subtitulos o no 
        /// </summary>
        /// <param name="subtitulos"> puede ser true o false </param>
        public void Reproducir(bool subtitulos)
        {
            Reproducir();
            if (subtitulos)
            {
                Console.WriteLine("Subtítulos disponibles");
            }
            else
            {
                Console.WriteLine("No hay subtitulos disponibles");
            }
        }
        #endregion

        #region OPERADORES
        public static bool operator ==(Pelicula p1, Pelicula p2)
        {
            return p1.titulo == p2.titulo && p1.estreno == p2.estreno;
        }

        public static bool operator !=(Pelicula p1, Pelicula p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Operador convierte implicitamente el objeto pelicula a un entero,
        /// que hace referencia al año de estreno.
        /// </summary>
        /// <param name="pelicula"> un objeto pelicula</param>
        public static implicit operator int(Pelicula pelicula)
        {
            return pelicula.estreno;
        }

        #endregion  

        #region SOBREESCRITURA EQUIVALENCIAS
        /// <summary>
        /// Determina si el objeto actual es igual a otro objeto. 
        /// La comparación se basa en el título y el año de estreno.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si los objetos son iguales, false en caso contrario.</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Pelicula pelicula)
            {
                retorno =  this == pelicula;
            }
            return retorno;
        }
        /// <summary>
        /// Calcula un código hash para la instancia actual de Pelicula. 
        /// El código hash se basa en el título y el año de estreno.
        /// </summary>
        /// <returns>Un código hash para la instancia actual.</returns>
        public override int GetHashCode()
        {
            return (this.titulo,this.estreno).GetHashCode();
        }
        #endregion

        /// <summary>
        /// se encargar de mostrar la info de la pelicula
        /// </summary>
        /// <returns>un formato de cadena representando la película</returns>
        public string Mostrar()
        {
            return $"{this.titulo} ({this.estreno}) - {this.nacionalidad}";
        }

       

    }
}
