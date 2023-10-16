﻿using Entidades;
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
    public partial class FormPeliculaAccion : FormPeliculas
    {
        public Entidades.PeliculaAccion peli;
        public FormPeliculaAccion(Entidades.PeliculaAccion p) : this()
        {
            base.ModificarForm(p);

            this.cmbActorPrincipal.SelectedItem = p.ActorPrincipal;
            this.cmbArmas.SelectedItem = p.Armas;
        }

        public FormPeliculaAccion():base()
        {
            InitializeComponent();
            this.AgregarActoresCmbox();
            this.AgregarArmasCmbox();

            this.peli = new PeliculaAccion();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtDirector.Text) ||
                cmbActorPrincipal.SelectedItem == null || cmbArmas.SelectedItem == null)
            {
                //muestra un mensaje de error si los campos no están completos
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

        private void AgregarArmasCmbox()
        {
            this.cmbArmas.Items.Add("Pistola");
            this.cmbArmas.Items.Add("Arco y Flecha");
            this.cmbArmas.Items.Add("Metralladora");
            this.cmbArmas.Items.Add("Rifle");
            this.cmbArmas.Items.Add("Escopeta");
        }

        private void FormPeliculaAccion_Load(object sender, EventArgs e)
        {
            cmbActorPrincipal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArmas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
