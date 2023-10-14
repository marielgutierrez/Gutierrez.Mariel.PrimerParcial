using System.Text;

namespace Entidades
{
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

        public PeliculaTerror():base()
        {
            this.personaje = EPersonajes.Desconocido;
            this.tipoTerror = "No encontrado";
        }

        #region METODOS OVERRIDE
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

        public override void ClasificarPelicula()
        {
            Console.WriteLine("Clasificación: D (para mayores de 18 años)");

        }
        #endregion

        //public override bool Equals(object? obj)
        //{
        //    bool retorno = false; // es mejor crear una variable antes de devolver dos return

        //    if (obj is Pelicula)
        //    {
        //        retorno = this == (Pelicula)obj;
        //    }
        //    return retorno;
        //}

        public override string ToString()
        {
            return this.MostrarInformacion();
        }
    }
}