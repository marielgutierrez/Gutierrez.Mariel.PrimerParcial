using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulario
{
    /// <summary>
    /// Clase derivada, maneja los componentes base y especificos del tipo de pelicula (Acción)
    /// </summary>
    public partial class FormPeliculaAccion : FormPeliculas
    {
        public Entidades.PeliculaAccion peli;

        /// <summary>
        /// Constructor que permite manejar los atributos de la pelicula
        /// traida por parametro. 
        /// </summary>
        /// <param name="p"> la pelicula de accion a modificar</param>
        public FormPeliculaAccion(Entidades.PeliculaAccion p) : this()
        {
            base.ModificarForm(p);

            this.cmbActorPrincipal.SelectedItem = p.ActorPrincipal;
            this.cmbArmas.SelectedItem = p.Armas;
        }

        /// <summary>
        /// Inicializa los componentes de la clase base y los propios.
        /// </summary>
        public FormPeliculaAccion():base()
        {
            InitializeComponent();
            this.AgregarActoresCmbox();
            this.AgregarArmasCmbox();

            this.peli = new PeliculaAccion();
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
                cmbActorPrincipal.SelectedItem == null || cmbArmas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int valorEstreno = (int)nupEstreno.Value;
                ENacionalidad nacionalidadSeleccionada = (ENacionalidad)base.cmbNacionalidad.SelectedItem;
                string actorSeleccionado = cmbActorPrincipal.SelectedItem?.ToString() ?? "Desconocido";
                string armaSeleccionada = cmbArmas.SelectedItem?.ToString() ?? "No encontrada";

                if (base.CargarFormulario())
                {
                    this.peli = new PeliculaAccion(base.txtTitulo.Text, valorEstreno, base.txtDirector.Text,
                        nacionalidadSeleccionada, actorSeleccionado, armaSeleccionada);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// Agrega las opciones de Actores al combobox correspondiente
        /// </summary>
        private void AgregarActoresCmbox()
        {
            this.cmbActorPrincipal.Items.Add("Jackie Chan");
            this.cmbActorPrincipal.Items.Add("Tom Cruise");
            this.cmbActorPrincipal.Items.Add("Liam Neeson");
            this.cmbActorPrincipal.Items.Add("Dwayne Jhonson");
            this.cmbActorPrincipal.Items.Add("Will Smith");
            this.cmbActorPrincipal.Items.Add("Vin Diesel");
            this.cmbActorPrincipal.Items.Add("Scarlett Johansson");
        }

        /// <summary>
        /// Agrega las opciones de Armas al combobox correspondiente
        /// </summary>
        private void AgregarArmasCmbox()
        {
            this.cmbArmas.Items.Add("Pistola");
            this.cmbArmas.Items.Add("Arco y Flecha");
            this.cmbArmas.Items.Add("Metralladora");
            this.cmbArmas.Items.Add("Rifle");
            this.cmbArmas.Items.Add("Escopeta");
        }
        /// <summary>
        /// Permite que el usuario no pueda escribir sobre los combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPeliculaAccion_Load(object sender, EventArgs e)
        {
            this.cmbActorPrincipal.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbArmas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
