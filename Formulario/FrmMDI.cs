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
    /// Clase derivada de Form, cumple el rol de manejar otras 
    /// ventanas dentro de una única aplicación principal.
    /// </summary>
    public partial class FrmMDI : Form
    {
        private FrmPrincipal? form1;
        private FrmUsuarios? form2;
        /// <summary>
        /// Inicializa los componentes del formulario.
        /// </summary>
        public FrmMDI()
        {
            InitializeComponent();

            this.Text = "CineFlix";
        }
        /// <summary>
        /// Constructor se encarga de inicializar los componentes y
        /// armar una cadena de texto con el nombre del usuario 'logueado' y la fecha de registro
        /// </summary>
        /// <param name="u"></param>
        public FrmMDI(Usuario u) : this()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Bienvenido/a {u.Nombre}");
            sb.AppendLine($"Fecha de registro: {DateTime.Now.ToString("dd/MM/yyyy")}");
            sb.ToString();

            lblUsuario.Text = sb.ToString();

            this.CrearArchivoUsuario(u);

        }
        /// <summary>
        /// Maneja el evento Click del elemento de menú "Mis Películas". 
        /// Abre una nueva ventana para mostrar la lista de películas del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        void CerrarForm1(object? sender, FormClosedEventArgs e)
        {
            //sender = sender ?? this;
            this.form1 = null;
        }

        /// <summary>
        /// Se encarga de establecer el fondo de la ventana del MDI
        /// </summary>
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
        /// <summary>
        /// Se encarga de crear el archivo usuarios.log si no existe,
        /// y escribe una linea con la informacion del usuario 'logueado'
        /// </summary>
        /// <param name="u"> el usuario 'logueado'</param>
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
        /// <summary>
        /// Maneja el evento Click del elemento de menú "Ver Usuarios". 
        /// Abre una nueva ventana para mostrar la lista de usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        void CerrarForm2(object? sender, FormClosedEventArgs e)
        {
            this.form2 = null;
        }
    }
}
