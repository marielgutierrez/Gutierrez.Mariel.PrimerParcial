using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase que contiene la colección genérica de peliculas
    /// </summary>
    [XmlInclude(typeof(Entidades.PeliculaAccion))]
    [XmlInclude(typeof(Entidades.PeliculaTerror))]
    [XmlInclude(typeof(Entidades.PeliculaComedia))]
    [XmlRoot("Peliculas")]
    public class MisPeliculas
    {
        protected List<Pelicula> peliculas;

        public MisPeliculas()
        {
            this.peliculas = new List<Pelicula>();
        }

        [XmlElement("Pelicula")]
        public List<Pelicula> Peliculas
        {
            get { return this.peliculas; }
            set { this.peliculas = value; }
        }

        /// <summary>
        /// comparacion, recorre la lista de peliculas 
        /// en caso de que otra pelicula "p" sea igual a alguna de las peliculas en la lista
        /// </summary>
        /// <param name="p"> pelicula creada por el usuario</param>
        /// <param name="mp"> clase que contiene la lista de peliculas</param>
        /// <returns> true si son iguales, de lo contrario false</returns>
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
        /// <summary>
        /// niega la comparacion del ==
        /// </summary>
        /// <param name="p">pelicula creada por el usuario</param>
        /// <param name="mp"> clase que contiene la lista de peliculas</param>
        /// <returns>true si son distintos, de lo contrario true</returns>
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
        /// <summary>
        /// Compara dos objetos de tipo Pelicula y los ordena por el título en orden ascendente
        /// </summary>
        /// <param name="p1">un objeto pelicula</param>
        /// <param name="p2">otro objeto pelicula</param>
        /// <returns>
        /// Un valor menor que cero si el título de p1 es lexicográficamente anterior al título de p2.
        /// Cero si los títulos son iguales.
        /// Un valor mayor que cero si el título de p1 es lexicográficamente posterior al título de p2.
        /// </returns>
        public static int OrdenarPorTituloAscendente(Pelicula p1, Pelicula p2)
        {
            return string.Compare(p1.Titulo, p2.Titulo, StringComparison.OrdinalIgnoreCase);
        }
        /// <summary>
        /// Compara dos objetos de tipo Pelicula y los ordena por el título en orden descendente
        /// </summary>
        /// <param name="p1">un objeto pelicula</param>
        /// <param name="p2">otro objeto pelicula</param>
        /// <returns>
        /// Un valor mayor que cero si el título de p1 es lexicográficamente anterior al título de p2.
        /// Cero si los títulos son iguales.
        /// Un valor menor que cero si el título de p1 es lexicográficamente posterior al título de p2.
        /// </returns>
        public static int OrdenarPorTituloDescendente(Pelicula p1, Pelicula p2)
        {
            return string.Compare(p2.Titulo, p1.Titulo, StringComparison.OrdinalIgnoreCase);
        }
        /// <summary>
        /// Compara dos objetos de tipo Pelicula y los ordena por el año de estreno en orden ascendente
        /// </summary>
        /// <param name="p1">un objeto pelicula</param>
        /// <param name="p2">otro objeto pelicula</param>
        /// <returns>
        /// Un valor entero que indica la relación de orden entre los objetos
        /// </returns>
        public static int OrdenarPorEstrenoAscendente(Pelicula p1, Pelicula p2)
        {
            if (p1.Estreno < p2.Estreno)
            {
                return -1;
            }
            else if (p1.Estreno > p2.Estreno)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Compara dos objetos de tipo Pelicula y los ordena por el año de estreno en orden descendente
        /// </summary>
        /// <param name="p1">un objeto pelicula</param>
        /// <param name="p2">otro objeto pelicula</param>
        /// <returns>
        /// Un valor entero que indica la relación de orden entre los objetos
        /// </returns>
        public static int OrdenarPorEstrenoDescendente(Pelicula p1, Pelicula p2)
        {
            if (p1.Estreno < p2.Estreno)
            {
                return 1;
            }
            else if (p1.Estreno > p2.Estreno)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        //public override bool Equals(object obj)
        //{

        //    if (obj == null || !(obj is MisPeliculas))
        //    {
        //        return false;
        //    }

        //    MisPeliculas otraMisPeliculas = (MisPeliculas)obj;
        //    return true;
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

    }
}
