using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PeliculaAccion : Pelicula
    {
        protected string actorPrincipal;
        protected string armas;


        public PeliculaAccion(string titulo,int estreno, string director, 
            ENacionalidad nacionalidad, string actorPrincipal, string armas)
            : base(titulo, estreno, director, nacionalidad)
        {
            this.armas = armas;
            this.actorPrincipal = actorPrincipal;
        }

        public PeliculaAccion(string titulo, int estreno, string director,
            ENacionalidad nacionalidad, string actorPrincipal)
            : this(titulo, estreno, director, nacionalidad, actorPrincipal, "Arma de Fuego")
        {

        }

        public PeliculaAccion() :base()
        {
            this.actorPrincipal = "Desconocido";
            this.armas = "SIN ARMAS";
        }

        #region METODOS OVERRIDE
        protected override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarInformacion());
            sb.AppendLine("Actor Principal: "+this.actorPrincipal);
            sb.AppendLine("Armas: "+this.armas);
            sb.AppendLine("");

            return sb.ToString();
        }
        public override void ClasificarPelicula()
        {
            Console.WriteLine("Clasificación: B-15 (para mayores de 15 años)");
        }
        #endregion

        public override string ToString()
        {
            return this.MostrarInformacion();
        }
    }
}
