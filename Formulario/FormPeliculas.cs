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
    /// <summary>
    /// Clase base, maneja componentes principales de un form sobre peliculas
    /// </summary>
    public partial class FormPeliculas : Form
    {
        /// <summary>
        /// Inicializa los componentes principales
        /// </summary>
        public FormPeliculas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AgregarEstrenosDup();

            ENacionalidad[] nacionalidades = (ENacionalidad[])Enum.GetValues(typeof(ENacionalidad));
            this.cmbNacionalidad.DataSource = nacionalidades;
        }
        /// <summary>
        /// Permite que el usuario no pueda escribir sobre el combobox de nacionalidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Se encarga de cargar los controles del formulario.
        /// </summary>
        /// <returns>true o false</returns>
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
        /// <summary>
        /// Se encarga de agregar las opciones de un valor minimo a un maximo
        /// para seleccionar el año de estreno de la pelicula
        /// </summary>
        protected void AgregarEstrenosDup()
        {
            this.nupEstreno.Minimum = 1990;
            this.nupEstreno.Maximum = 2023;
        }
        /// <summary>
        /// Se encarga de cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Se encarga de manejar los datos de la pelicula que el usuario
        /// seleccionó para modificar
        /// </summary>
        /// <param name="p"> la pelicula a modificar </param>
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
