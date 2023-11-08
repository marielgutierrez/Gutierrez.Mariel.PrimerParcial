using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase derivada que maneja atributos propios (actor principal y armas) y los de la clase base Pelicula
    /// </summary>
    public class PeliculaAccion : Pelicula
    {
        private string actorPrincipal;
        private string armas;


        public string ActorPrincipal
        {
            get { return this.actorPrincipal; }
            set { this.actorPrincipal = value; }
        }

        public string Armas
        {
            get { return this.armas; }
            set { this.armas = value; }
        }
        /// <summary>
        /// Inicializa los atributos con los valores recibidos por parametro
        /// </summary>
        /// <param name="titulo">titulo de la pelicula</param>
        /// <param name="estreno"> estreno (año) de la pelicula</param>
        /// <param name="director"> director de la pelicula</param>
        /// <param name="nacionalidad">origen de la pelicula</param>
        /// <param name="actorPrincipal">actor principal de la pelicula</param>
        /// <param name="armas">arma utilizada en la pelicula</param>
        public PeliculaAccion(string titulo,int estreno, string director, 
            ENacionalidad nacionalidad, string actorPrincipal, string armas)
            : base(titulo, estreno, director, nacionalidad)
        {
            this.armas = armas;
            this.actorPrincipal = actorPrincipal;
        }
        /// <summary>
        /// Permite crear una película de acción especificando el título, año de estreno,
        /// director, nacionalidad, y actor principal.
        /// Por defecto, el arma principal se establece como "Arma de Fuego".
        /// </summary>
        /// <param name="titulo"> titulo de la pelicula</param>
        /// <param name="estreno"> estreno (año) de la pelicula</param>
        /// <param name="director"> director de la pelicula</param>
        /// <param name="nacionalidad">origen de la pelicula</param>
        /// <param name="actorPrincipal">actor principal de la pelicula</param>
        public PeliculaAccion(string titulo, int estreno, string director,
            ENacionalidad nacionalidad, string actorPrincipal)
            : this(titulo, estreno, director, nacionalidad, actorPrincipal, "Arma de Fuego")
        {

        }
        /// <summary>
        /// Inicializa los atributos con valores predeterminados.
        /// </summary>
        public PeliculaAccion() :base()
        {
            this.actorPrincipal = "Desconocido";
            this.armas = "SIN ARMAS";
        }

        #region METODOS OVERRIDE
        /// <summary>
        /// Se encarga de mostrar en una cadena de texto la informacion de la clase base
        /// y agrega los atributos de la clase propia.
        /// </summary>
        /// <returns>informacion de la pelicula de acción</returns>
        protected override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarInformacion());
            sb.AppendLine("Actor Principal: "+this.actorPrincipal);
            sb.AppendLine("Armas: "+this.armas);
            sb.AppendLine("");

            return sb.ToString();
        }
        /// <summary>
        /// Se encarga de mostrar la clasificación de la pelicula según el rango de edad apto para esta.
        /// </summary>
        public override void ClasificarPelicula()
        {
            Console.WriteLine("Clasificación: B-15 (para mayores de 15 años)");
        }
        #endregion
        /// <summary>
        /// Utiliza la implementación base de Equals y atributos propios (actorPrincipal y armas) para comparar las instancias.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// <c>true</c> si el objeto especificado es igual a la instancia actual; de lo contrario, <c>false</c>.
        /// </returns>
        public override bool Equals(object? obj)
        {
            if (obj is PeliculaAccion otraPeliAccion)
            {
                return base.Equals(obj) &&
                       this.actorPrincipal == otraPeliAccion.actorPrincipal &&
                       this.armas == otraPeliAccion.armas;
            }
            return false;

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
