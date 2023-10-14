using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MisPeliculas
    {
        protected List<Pelicula> peliculas;

        public MisPeliculas()
        {
            this.peliculas = new List<Pelicula>();
        }

        public List<Pelicula> Peliculas
        {
            get { return this.peliculas; }
            set { this.peliculas = value; }
        }

        /// <summary>
        /// comparacion, recorre la lista de peliculas 
        /// en caso de que otra pelicula "p" sea igual a alguna de las peliculas en la lista
        /// </summary>
        /// <param name="p"></param>
        /// <param name="mp"></param>
        /// <returns> retorno (true o false)</returns>
        public static bool operator ==(Pelicula p, MisPeliculas mp)
        {
            bool retorno = false;
            foreach (Pelicula item in mp.Peliculas)
            {
                if (item == p)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;

        }

        public static bool operator !=(Pelicula p, MisPeliculas mp)
        {
            return !(p == mp);
        }

        /// <summary>
        /// adición, verifica si la pelicula "p" 
        /// no está en la lista de peliculas "mispelis", se agrega
        /// </summary>
        /// <param name="mispelis"></param>
        /// <param name="p"></param>
        /// <returns>lista de peliculas</returns>
        public static MisPeliculas operator +(MisPeliculas mispelis, Pelicula p)
        {
            if (p != mispelis)
            {
                mispelis.Peliculas.Add(p);
            }
            else
            {
                Console.WriteLine("La pelicula ya está en la lista");
            }
            return mispelis;
        }

        /// <summary>
        /// sustracción, verifica si la pelicula "p"
        /// está en la lista de peliculas "mispelis", se elimina
        /// </summary>
        /// <param name="mispelis"></param>
        /// <param name="p"></param>
        /// <returns>lista de peliculas</returns>
        public static MisPeliculas operator -(MisPeliculas mispelis, Pelicula p)
        {
            if (p == mispelis)
            {
                mispelis.Peliculas.Remove(p);
            }

            return mispelis;
        }

    }
}
