using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {

        //private string nombre;
        private string apellido;
        private int legajo;
        //private string correo;
        //private string clave;
        private EPerfil perfil;

        
        public string nombre { get; set; }
        public string correo  { get; set; }
        public string clave { get; set; }


        public override string ToString()
        {
            return $"usuario: {this.correo} - nombre: {this.nombre}";
        }

        public Usuario() { }

        public static string FormatearUsuario(Usuario u)
        {
            return $"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}]";
        }


    }
}
