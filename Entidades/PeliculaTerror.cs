using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase derivada, maneja los atributos propios (personaje principal y tipo de terror) 
    /// y de la clase base.
    /// </summary>
    public class PeliculaTerror : Pelicula
    {
        private EPersonajes personaje;
        private string tipoTerror;

        public EPersonajes Personaje
        {
            get { return this.personaje; }
            set { this.personaje = value; }
        }

        public string TipoTerror
        {
            get { return this.tipoTerror; }
            set { this.tipoTerror = value; }
        }

        /// <summary>
        /// Inicializa todos los atributos con los valores traidos por parametro
        /// </summary>
        /// <param name="titulo"> titulo de la pelicula</param>
        /// <param name="estreno"> estreno (año) de la pelicula</param>
        /// <param name="director"> director de la pelicula</param>
        /// <param name="nacionalidad"> origen de la pelicula</param>
        /// <param name="personaje"> personaje principal de la pelicula</param>
        /// <param name="tipoTerror"> tipo de terror de la pelicula</param>
        public PeliculaTerror(string titulo, int estreno, string director, 
            ENacionalidad nacionalidad, EPersonajes personaje, string tipoTerror)
            : base(titulo, estreno, director, nacionalidad)
        {
            this.personaje = personaje;
            this.tipoTerror = tipoTerror;
        }
        /// <summary>
        /// Permite crear una película de acción especificando el título, año de estreno,
        /// director, nacionalidad, y tipo de terror.
        /// Por defecto, el personaje se establece como Dracula.
        /// </summary>
        /// <param name="titulo"> titulo de la pelicula</param>
        /// <param name="estreno"> estreno (año) de la pelicula</param>
        /// <param name="director"> director de la pelicula</param>
        /// <param name="nacionalidad"> origen de la pelicula</param>
        /// <param name="tipoTerror"> tipo de terror de la pelicula</param>
        public PeliculaTerror(string titulo, int estreno, string director,
            ENacionalidad nacionalidad, string tipoTerror)
            : this(titulo, estreno, director, nacionalidad, EPersonajes.Dracula, tipoTerror)
        {
           
        }
        /// <summary>
        /// LLama al constructor de la clase base e
        /// inicializa los atributos propios de la clase
        /// </summary>
        public PeliculaTerror():base()
        {
            this.personaje = EPersonajes.Desconocido;
            this.tipoTerror = "No encontrado";
        }

        #region METODOS OVERRIDE

        /// <summary>
        /// Llama al metodo MostrarInformacion de la clase base
        /// y agrega una cadena de texto de los atributos propios
        /// </summary>
        /// <returns>informacion de la pelicula de terror</returns>
        protected override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarInformacion());
            sb.AppendLine("Tipo de terror: "+this.tipoTerror);
            sb.AppendLine("Personaje principal: "+this.personaje);
            sb.AppendLine("");

            return sb.ToString();
        }

        /// <summary>
        /// Se encarga de mostrar la clasificación de la pelicula según el rango de edad apto para esta.
        /// </summary>
        public override void ClasificarPelicula()
        {
            Console.WriteLine("Clasificación: D (para mayores de 18 años)");

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