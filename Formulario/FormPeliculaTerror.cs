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
    public partial class FormPeliculaTerror : FormPeliculas
    {
        public Entidades.PeliculaTerror peli;
        public FormPeliculaTerror(Entidades.PeliculaTerror p) : this()
        {
            this.txtTitulo.Text = p.Titulo;
            this.nupEstreno.Value = p.Estreno;
            this.txtDirector.Text = p.Director;

            if (cmbNacionalidad.SelectedItem != null)
            {
                p.Nacionalidad = (ENacionalidad)cmbNacionalidad.SelectedItem;
            }

            this.cmbPersonaje.SelectedItem = p.Personaje;
            this.cmbTerror.SelectedItem = p.TipoTerror;

            this.nupEstreno.Enabled = false;
        }


        public FormPeliculaTerror():base()
        {
            InitializeComponent();
            EPersonajes[] personajes = (EPersonajes[])Enum.GetValues(typeof(EPersonajes));
            this.cmbPersonaje.DataSource = personajes;

            this.AgregarTerrorCmbox();
            this.peli = new PeliculaTerror();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtDirector.Text) || cmbTerror.SelectedItem == null)
            {
                //muestra un mensaje de error si los campos no están completos
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int estreno = (int)this.nupEstreno.Value; //ACA TIRA ERROR

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

        private void AgregarTerrorCmbox()
        {
            this.cmbTerror.Items.Add("Gore");
            this.cmbTerror.Items.Add("Psicológico");
            this.cmbTerror.Items.Add("Paranormal");
            this.cmbTerror.Items.Add("Horror");
            this.cmbTerror.Items.Add("Slasher");
            this.cmbTerror.Items.Add("Thriller");
        }

        private void FormPeliculaTerror_Load(object sender, EventArgs e)
        {
            cmbPersonaje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTerror.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
