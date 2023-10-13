namespace Entidades
{
    public class PeliculaTerror : Pelicula
    {
        protected bool musicaSuspenso;

        public PeliculaTerror(string titulo, int duracion, int año, string director, bool subtitulos, bool musicaSuspenso)
            : base(titulo, duracion, año, director, subtitulos)
        {
            this.musicaSuspenso  = musicaSuspenso;
        }

        public PeliculaTerror()
        {

        }
    }
}