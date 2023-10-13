using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PeliculaComedia : Pelicula
    {
        protected string actorPrincipal;
        protected string tipoComedia;

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

        public PeliculaComedia() : base()
        {
            this.actorPrincipal = "Desconocido";
            this.tipoComedia = "No encontrado";
        }

        #region METODOS OVERRIDE (TERMINAR EL MOSTRAR)
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

        public override string ToString()
        {
            return this.MostrarInformacion();
        }
    }
}
