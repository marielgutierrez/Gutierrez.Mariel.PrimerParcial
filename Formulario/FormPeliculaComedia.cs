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
    /// Clase derivada, maneja los componentes base y especificos del tipo de pelicula (Comedia).
    /// </summary>
    public partial class FormPeliculaComedia : FormPeliculas
    {
        public Entidades.PeliculaComedia peli;

        /// <summary>
        /// Constructor que permite manejar los atributos de la pelicula
        /// traida por parametro. 
        /// </summary>
        /// <param name="p"> pelicula a modificar</param>
        public FormPeliculaComedia(Entidades.PeliculaComedia p) : this()
        {
            base.ModificarForm(p);

            this.cmbActorComedia.SelectedItem = p.ActorPrincipal;
            this.cmbComedia.SelectedItem = p.TipoComedia;
        }

        /// <summary>
        /// Inicializa los componentes de la clase base y los propios.
        /// </summary>
        public FormPeliculaComedia():base()
        {
            InitializeComponent();
            this.AgregarActoresComedia();
            this.AgregarComediaCmbox();
            this.peli = new PeliculaComedia();
        }

        /// <summary>
        /// Permite que el usuario no pueda escribir sobre los combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPelisComedia_Load(object sender, EventArgs e)
        {
            cmbActorComedia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComedia.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Cuando se da click al boton aceptar se toman los datos que ingresó el usuario
        /// sobre la pelicula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtDirector.Text) ||
                cmbActorComedia.SelectedItem == null || cmbComedia.SelectedItem == null)
            {
                //muestra un mensaje de error si los campos no están completos
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int estreno = (int)this.nupEstreno.Value;
                ENacionalidad nacionalidadSeleccionada = (ENacionalidad)base.cmbNacionalidad.SelectedItem;
                string actorSeleccionado = cmbActorComedia.SelectedItem?.ToString() ?? "Desconocido";
                string comediaSeleccionada = cmbComedia.SelectedItem?.ToString() ?? "No encontrada";

                if (base.CargarFormulario())
                {
                    this.peli = new PeliculaComedia(base.txtTitulo.Text, estreno, base.txtDirector.Text,
                        nacionalidadSeleccionada, actorSeleccionado, comediaSeleccionada);
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        /// <summary>
        /// Agrega las opciones de Actores al combobox correspondiente.
        /// </summary>
        private void AgregarActoresComedia()
        {
            this.cmbActorComedia.Items.Add("Jim Carrey");
            this.cmbActorComedia.Items.Add("Chris Rock");
            this.cmbActorComedia.Items.Add("Adam Sandler");
            this.cmbActorComedia.Items.Add("Jennifer Aniston");
            this.cmbActorComedia.Items.Add("Rowan Atkinson");
            this.cmbActorComedia.Items.Add("Danny Devito");
            this.cmbActorComedia.Items.Add("Jack Black");
        }

        /// <summary>
        /// Agrega las opciones de Tipo de Comedia al combobox correspondiente.
        /// </summary>
        private void AgregarComediaCmbox()
        {
            this.cmbComedia.Items.Add("Familiar");
            this.cmbComedia.Items.Add("Romantica");
            this.cmbComedia.Items.Add("Musical");
            this.cmbComedia.Items.Add("Humor Negro");
            this.cmbComedia.Items.Add("Parodia");
        }

    }
}
