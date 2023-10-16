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
    public partial class FormPeliculaComedia : FormPeliculas
    {
        public Entidades.PeliculaComedia peli;
        public FormPeliculaComedia(Entidades.PeliculaComedia p) : this()
        {
            this.txtTitulo.Text = p.Titulo;
            this.nupEstreno.Value = p.Estreno;
            this.txtDirector.Text = p.Director;

            if (cmbNacionalidad.SelectedItem != null)
            {
                p.Nacionalidad = (ENacionalidad)cmbNacionalidad.SelectedItem;
            }

            this.cmbActorComedia.SelectedItem = p.ActorPrincipal;
            this.cmbComedia.SelectedItem = p.TipoComedia;

            this.nupEstreno.Enabled = false;
        }


        public FormPeliculaComedia():base()
        {
            InitializeComponent();
            this.AgregarActoresComedia();
            this.AgregarComediaCmbox();
            this.peli = new PeliculaComedia();
        }

        private void FormPelisComedia_Load(object sender, EventArgs e)
        {
            cmbActorComedia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComedia.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

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
