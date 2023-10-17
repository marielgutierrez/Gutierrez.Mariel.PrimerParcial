using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que obtiene las caracteristicas del usuario al querer iniciar sesion
    /// </summary>
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;

        [JsonPropertyName("nombre")]
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        [JsonPropertyName("correo")]
        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        [JsonPropertyName("clave")]
        public string Clave
        {
            get { return this.clave; }
            set { this.clave = value; }
        }

        [JsonPropertyName("legajo")]
        public int Legajo 
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        [JsonPropertyName("apellido")]
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        [JsonPropertyName("perfil")]
        public string Perfil
        {
            get { return this.perfil; }
            set { this.perfil = value; }
        }

        /// <summary>
        /// Inicializa los atributos de Usuario con valores predeterminados
        /// </summary>
        public Usuario()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.correo = string.Empty;
            this.clave = string.Empty;
            this.perfil = string.Empty;
            this.legajo = 0;
        }
        /// <summary>
        /// Se encarga de obtener la fecha y hora actual en una cadena de texto
        /// </summary>
        /// <returns>la fecha y hora actual + informacion del usuario para el .log</returns>
        public override string ToString()
        {
            string fechaHoraActual = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            return $"[{fechaHoraActual}] correo: {this.correo} -" +
                $" nombre: {this.nombre} - apellido: {this.apellido} - legajo: {this.legajo} - perfil: {this.perfil}";
        }
    }
}
