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
            if (form1 == null)
            {
                form1 = new FrmPrincipal();
                form1.MdiParent = this;
                form1.FormClosed += new FormClosedEventHandler(CerrarForm);
                form1.StartPosition = FormStartPosition.CenterScreen;
                form1.Show();
            }
            else
            {
                form1.Activate();
            }


        }

        void CerrarForm(object sender, FormClosedEventArgs e)
        {
            sender = sender ?? this;
            form1 = null;
        }

        private void EstablecerImagenFondo()
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\pelis_fondito.jpg");
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
    }
}
