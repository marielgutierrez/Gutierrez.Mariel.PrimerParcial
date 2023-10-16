using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormPeliculas : Form
    {
        public FormPeliculas()
        {
            InitializeComponent();
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected bool CargarFormulario()
        {
            bool esta = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox & item.Text == String.Empty)
                {
                    esta = false;
                    break;
                }
            }
            return esta;
        }

        protected void AgregarEstrenosDup()
        {
            nupEstreno.Minimum = 1990;
            nupEstreno.Maximum = 2023;

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
