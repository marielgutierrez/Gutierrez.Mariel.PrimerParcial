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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            this.Text = "Ver Usuarios";
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\pelis_fondito.jpg");
            this.BackgroundImage = img;
            this.LeerArchivoLog();
        }
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
