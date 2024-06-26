﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase derivada que maneja atributos propios (actor principal y tipo de comedia)
    /// y los de la clase base Pelicula.
    /// </summary>
    public class PeliculaComedia : Pelicula
    {
        private string actorPrincipal;
        private string tipoComedia;


        public string ActorPrincipal
        {
            get { return this.actorPrincipal; }
            set { this.actorPrincipal = value; }
        }
        public string TipoComedia
        {
            get { return this.tipoComedia; }
            set { this.tipoComedia = value; }
        }

        /// <summary>
        /// Inicializa los atributos con los valores recibidos por parametro
        /// </summary>
        /// <param name="titulo"> titulo de la pelicula</param>
        /// <param name="estreno"> estreno (año) de la pelicula</param>
        /// <param name="director"> director de la pelicula</param>
        /// <param name="nacionalidad"> origen de la pelicula</param>
        /// <param name="actorPrincipal"> actor principal de la pelicula</param>
        /// <param name="tipoComedia"> tipo de comedia de la pelicula</param>
        public PeliculaComedia(string titulo, int estreno, string director, 
            ENacionalidad nacionalidad, string actorPrincipal, string tipoComedia)
            : base(titulo, estreno, director, nacionalidad)
        {
            this.actorPrincipal = actorPrincipal;   
            this.tipoComedia = tipoComedia;
        }
        /// <summary>
        /// Permite crear una película de acción especificando el título, año de estreno,
        /// director, nacionalidad, y actor principal.
        /// Por defecto, el tipo de comedia se establece como "Familiar".
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="estreno"></param>
        /// <param name="director"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="actorPrincipal"></param>
        public PeliculaComedia(string titulo, int estreno, string director,
            ENacionalidad nacionalidad, string actorPrincipal)
            : this(titulo, estreno, director, nacionalidad, actorPrincipal, "Familiar")
        {

        }
        /// <summary>
        /// Inicializa los atributos con valores predeterminados
        /// </summary>
        public PeliculaComedia() : base()
        {
            this.actorPrincipal = "Desconocido";
            this.tipoComedia = "No encontrado";
        }

        #region METODOS OVERRIDE
        /// <summary>
        /// Se encarga de mostrar en una cadena de texto la informacion de la clase base
        /// y agrega los atributos de la clase propia.
        /// </summary>
        /// <returns>informacion de la pelicula de comedia</returns>
        protected override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarInformacion());
            sb.AppendLine("Actor Principal: "+this.actorPrincipal);
            sb.AppendLine("Tipo de comedia: "+this.tipoComedia);
            sb.AppendLine("");

            return sb.ToString();
        }
        /// <summary>
        /// Se encarga de mostrar la clasificación de la pelicula según el rango de edad apto para esta.
        /// </summary>
        public override void ClasificarPelicula()
        {
            Console.WriteLine("Clasificación: A (para todo público)");
        }
        #endregion
        /// <summary>
        /// Utiliza la implementación base de Equals para comparar las instancias de manera predeterminada.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// <c>true</c> si el objeto especificado es igual a la instancia actual; de lo contrario, <c>false</c>.
        /// </returns>
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// Utiliza el mismo criterio de hash que la clase base.
        /// </summary>
        /// <returns>El código hash calculado para la instancia actual</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Utiliza el método MostrarInformacion para generar la representación de la película.
        /// </summary>
        /// <returns>Una cadena que representa la información detallada de la película.</returns>
        public override string ToString()
        {
            return this.MostrarInformacion();
        }
    }
}
