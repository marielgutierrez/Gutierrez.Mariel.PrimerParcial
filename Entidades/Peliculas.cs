using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Peliculas
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public int Año { get; set; }


        /*OTRAS IDEAS PARA ATRIBUTOS/PROPIEDADES
         * pais de origen, contiene subtitulos, director, antagonista, 
         */

        public override string ToString()
        {
            return $"{Titulo} ({Año})"; // Devuelve un formato de cadena representando la película
        }
    }
}
