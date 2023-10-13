using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PeliculaAccion : Pelicula
    {
        protected bool efectosEspeciales;

        public PeliculaAccion(string titulo,int duracion, int año, string director, bool subtitulos, bool efectosEspeciales)
            : base(titulo, duracion,año, director, subtitulos)
        {
            this.efectosEspeciales = efectosEspeciales;
        }

        public PeliculaAccion()
        {
                
        }



    }
}
