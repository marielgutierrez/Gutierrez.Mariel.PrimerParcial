using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase derivada que maneja atributos propios y de la base
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
        protected override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarInformacion());
            sb.AppendLine("Actor Principal: "+this.actorPrincipal);
            sb.AppendLine("Tipo de comedia: "+this.tipoComedia);
            sb.AppendLine("");

            return sb.ToString();
        }

        public override void ClasificarPelicula()
        {
            Console.WriteLine("Clasificación: A (para todo público)");
        }
        #endregion

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.MostrarInformacion();
        }
    }
}
