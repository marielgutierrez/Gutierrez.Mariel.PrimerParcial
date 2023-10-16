using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase derivada contiene los atributos propios
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

        public PeliculaTerror(string titulo, int estreno, string director,
            ENacionalidad nacionalidad, string tipoTerror)
            : this(titulo, estreno, director, nacionalidad, EPersonajes.Dracula, tipoTerror)
        {
           
        }
        /// <summary>
        /// llama al constructor de la clase base e
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
        /// <returns></returns>
        protected override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarInformacion());
            sb.AppendLine("Tipo de terror: "+this.tipoTerror);
            sb.AppendLine("Personaje principal: "+this.personaje);
            sb.AppendLine("");

            return sb.ToString();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Sobrescribe el metodo ClasificarPelicula de la clase base
        /// </summary>
        public override void ClasificarPelicula()
        {
            Console.WriteLine("Clasificación: D (para mayores de 18 años)");

        }
        #endregion

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
            
            //bool retorno = false; // es mejor crear una variable antes de devolver dos return

            //if (obj is Pelicula)
            //{
            //    retorno = this == (Pelicula)obj;
            //}
            //return retorno;
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