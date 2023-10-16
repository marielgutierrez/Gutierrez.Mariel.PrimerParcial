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
    public partial class FrmMDI : Form
    {
        private FrmPrincipal? form1;
        private FrmUsuarios? form2;
        public FrmMDI()
        {
            InitializeComponent();

            this.Text = "CineFlix";
            //form1 = null;
        }
        public FrmMDI(Usuario u) : this()
        {
            lblUsuario.Text = $"Bienvenido/a {u.Nombre} - [{DateTime.Now.ToString("dd/MM/yyyy")}]";

            this.CrearArchivoUsuario(u);

        }

        private void misPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.form1 == null)
            {
                this.form1 = new FrmPrincipal();
                this.form1.MdiParent = this;
                this.form1.FormClosed += new FormClosedEventHandler(CerrarForm1);
                this.form1.StartPosition = FormStartPosition.CenterScreen;
                this.form1.Show();
            }
            else
            {
                this.form1.Activate();
            }
        }

        void CerrarForm1(object sender, FormClosedEventArgs e)
        {
            //sender = sender ?? this;
            this.form1 = null;
        }

        private void EstablecerImagenFondo()
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\nueva_portada.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            this.EstablecerImagenFondo();
        }

        private void FrmMDI_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void CrearArchivoUsuario(Usuario u)
        {
            string filePath = "usuario.log";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(u.ToString());
            }
        }
        /// <summary>
        /// Posibilidad de cancelar el cierre de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quiere salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.form2 == null)
            {
                this.form2 = new FrmUsuarios();
                this.form2.MdiParent = this;
                this.form2.FormClosed += new FormClosedEventHandler(CerrarForm2);
                this.form2.StartPosition = FormStartPosition.CenterScreen;
                this.form2.Show();
            }
            else
            {
                this.form2.Activate();
            }

        }
        void CerrarForm2(object sender, FormClosedEventArgs e)
        {
            //sender = sender ?? this;
            this.form2 = null;
        }
    }
}
