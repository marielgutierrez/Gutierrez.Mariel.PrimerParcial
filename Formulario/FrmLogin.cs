using Entidades;
using System.Text.Json;

namespace Formulario
{
    /// <summary>
    /// Clase que deriva de Form, cumple el rol de un formulario de Inicio de sesión.
    /// Verifica que los datos ingresados por el usuario sean válidos para el ingreso a la aplicación.
    /// </summary>
    public partial class FrmLogin : Form
    {
        private Usuario usuario;
        public Usuario UsuarioDelForm
        {
            get { return this.usuario; }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        //public FrmLogin(Usuario usuario): this()
        //{
        //    this.usuario = usuario;
        //    this.txtCorreo.Focus();
        //}
        /// <summary>
        /// Cuando se hace click en el boton Ingresar
        /// se verifica que los datos sean validos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.usuario = this.Verificar();
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Se encarga de verificar, al deserializar el json con los usuarios,
        /// que los datos ingresados (correo y clave) coincidan con alguno de los
        /// usuarios del archivo.
        /// </summary>
        /// <returns> un objeto Usuario</returns>
        private Usuario Verificar()
        {
            Usuario? rta = null;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"..\..\..\MOCK_DATA.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;

                string json_str = sr.ReadToEnd();

                List<Usuario> users = JsonSerializer.Deserialize<List<Usuario>>(json_str, opciones);

                foreach (Usuario item in users)
                {
                    if (item.Correo == this.txtCorreo.Text && item.Clave == this.txtClave.Text)
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        /// <summary>
        /// Carga los Tooltips de los textbox correo y clave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.CrearToolTip(this.txtCorreo, "Ingresar correo electrónico.");
            this.CrearToolTip(this.txtClave, "Ingresar clave.");

        }
        /// <summary>
        /// Se encarga de crear los Tooltips del textbox y mensaje traidos por parametro.
        /// </summary>
        /// <param name="textBox"> elemento textbox del form</param>
        /// <param name="tip"> mensaje para vea el usuario</param>
        private void CrearToolTip(System.Windows.Forms.TextBox textBox, string tip)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(textBox, tip);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            //this.Close();

            //DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    this.DialogResult = DialogResult.Cancel;
            //    //this.Close(); //Cierra el formulario.
            //}
        }


    }
}