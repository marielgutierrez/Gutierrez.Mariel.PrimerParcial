using Entidades;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AgregarEstrenosDup();

            ENacionalidad[] nacionalidades = (ENacionalidad[])Enum.GetValues(typeof(ENacionalidad));
            this.cmbNacionalidad.DataSource = nacionalidades;
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
            this.nupEstreno.Minimum = 1990;
            this.nupEstreno.Maximum = 2023;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void ModificarForm(Pelicula p)
        {
            this.lblNombreForm.Text = "Modificar Película";
            this.txtTitulo.Text = p.Titulo;
            this.nupEstreno.Value = p.Estreno;
            this.txtDirector.Text = p.Director;

            if (this.cmbNacionalidad.SelectedItem != null)
            {
                p.Nacionalidad = (ENacionalidad)cmbNacionalidad.SelectedItem;
            }

            this.nupEstreno.Enabled = false;
        }

    }
}
