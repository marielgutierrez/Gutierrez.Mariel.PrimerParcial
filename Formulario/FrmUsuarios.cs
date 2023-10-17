using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    /// <summary>
    /// Clase derivada de Form, cumple el rol de visualizador de la 
    /// lista de usuarios que se encuentre en el archivo usuarios.log
    /// </summary>
    public partial class FrmUsuarios : Form
    {
        /// <summary>
        /// Inicializa los componentes del formulario y 
        /// llama al metodo LeerArchivoLog para leer el usuarios.log
        /// </summary>
        public FrmUsuarios()
        {
            InitializeComponent();
            this.Text = "Ver Usuarios";
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\pelis_fondito.jpg");
            this.BackgroundImage = img;
            this.LeerArchivoLog();
        }
        /// <summary>
        /// Se encarga de leer todas las lineas del archivo usuarios.log y
        /// agregarlas a un listbox para visualizar en el formulario.
        /// </summary>
        private void LeerArchivoLog()
        {
            string filePath = "usuario.log";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                lstUsuarios.Items.AddRange(lines);
            }
            else
            {
                MessageBox.Show("El archivo de registro no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
