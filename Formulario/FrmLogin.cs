using Entidades;
using System.Text.Json;

namespace Formulario
{
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
            this.usuario = new Usuario();

        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.usuario = this.Verificar();

            this.DialogResult = DialogResult.OK;

            //FrmPrincipal frmPrincipal = new FrmPrincipal(this.usuario);
            //frmPrincipal.ShowDialog();
        }

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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close(); //Cierra el formulario.
            }
        }

    }
}