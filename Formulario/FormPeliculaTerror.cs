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
    ///  Clase derivada, maneja los componentes base y especificos del tipo de pelicula (Terror).
    /// </summary>
    public partial class FormPeliculaTerror : FormPeliculas
    {
        public Entidades.PeliculaTerror peli;

        /// <summary>
        /// Constructor que permite manejar los atributos de la pelicula
        /// traida por parametro. 
        /// </summary>
        /// <param name="p"> pelicula a modificar</param>
        public FormPeliculaTerror(Entidades.PeliculaTerror p) : this()
        {
            base.ModificarForm(p);
            this.cmbPersonaje.SelectedItem = p.Personaje;
            this.cmbTerror.SelectedItem = p.TipoTerror;
        }
        /// <summary>
        /// Inicializa los componentes de la clase base y los propios.
        /// </summary>
        public FormPeliculaTerror():base()
        {
            InitializeComponent();
            EPersonajes[] personajes = (EPersonajes[])Enum.GetValues(typeof(EPersonajes));
            this.cmbPersonaje.DataSource = personajes;

            this.AgregarTerrorCmbox();
            this.peli = new PeliculaTerror();
        }

        /// <summary>
        /// Cuando se da click al boton aceptar se toman los datos que ingresó el usuario
        /// sobre la pelicula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtDirector.Text) || cmbTerror.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int estreno = (int)this.nupEstreno.Value;
                ENacionalidad nacionalidadSeleccionada = (ENacionalidad)base.cmbNacionalidad.SelectedItem;
                EPersonajes personajeSeleccionado = (EPersonajes)this.cmbPersonaje.SelectedItem;
                string comediaSeleccionada = cmbTerror.SelectedItem?.ToString() ?? "No encontrada";

                if (base.CargarFormulario())
                {
                    this.peli = new PeliculaTerror(base.txtTitulo.Text, estreno, base.txtDirector.Text,
                        nacionalidadSeleccionada, personajeSeleccionado, comediaSeleccionada);
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        /// <summary>
        /// Agrega las opciones de Personajes al combobox correspondiente
        /// </summary>
        private void AgregarTerrorCmbox()
        {
            this.cmbTerror.Items.Add("Gore");
            this.cmbTerror.Items.Add("Psicológico");
            this.cmbTerror.Items.Add("Paranormal");
            this.cmbTerror.Items.Add("Horror");
            this.cmbTerror.Items.Add("Slasher");
            this.cmbTerror.Items.Add("Thriller");
        }
        /// <summary>
        /// Permite que el usuario no pueda escribir sobre los combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPeliculaTerror_Load(object sender, EventArgs e)
        {
            cmbPersonaje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTerror.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
