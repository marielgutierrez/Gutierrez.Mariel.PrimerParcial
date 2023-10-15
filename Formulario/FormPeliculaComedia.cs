﻿using Entidades;
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
            this.dupEstreno.Text = p.Estreno.ToString();
            this.txtDirector.Text = p.Director;

            if (cmbNacionalidad.SelectedItem != null)
            {
                p.Nacionalidad = (ENacionalidad)cmbNacionalidad.SelectedItem;
            }

            this.cmbActorComedia.SelectedItem = p.ActorPrincipal;
            this.cmbComedia.SelectedItem = p.TipoComedia;

            this.dupEstreno.Enabled = false;
        }


        public FormPeliculaComedia()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            base.AgregarEstrenosDup();

            ENacionalidad[] nacionalidades = (ENacionalidad[])Enum.GetValues(typeof(ENacionalidad));
            this.cmbNacionalidad.DataSource = nacionalidades;

            this.AgregarActoresComedia();
            this.AgregarComediaCmbox();
            this.peli = new PeliculaComedia();
        }

        private void FormPelisComedia_Load(object sender, EventArgs e)
        {

        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int estreno = int.Parse(this.dupEstreno.Text);

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
