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
    public partial class FormPeliculaAccion : FormPeliculas
    {
        public Entidades.PeliculaAccion peli;
        public FormPeliculaAccion(Entidades.PeliculaAccion p) : this()
        {
            this.txtTitulo.Text = p.Titulo;
            this.dupEstreno.Text = p.Estreno.ToString();
            this.txtDirector.Text = p.Director;

            if (cmbNacionalidad.SelectedItem != null)
            {
                p.Nacionalidad = (ENacionalidad)cmbNacionalidad.SelectedItem; 
            }

            this.cmbActorPrincipal.SelectedItem = p.ActorPrincipal;
            this.cmbArmas.SelectedItem = p.Armas;

            this.dupEstreno.Enabled = false;
        }


        public FormPeliculaAccion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            base.AgregarEstrenosDup();

            ENacionalidad[] nacionalidades = (ENacionalidad[])Enum.GetValues(typeof(ENacionalidad));
            this.cmbNacionalidad.DataSource = nacionalidades;

            this.AgregarActoresCmbox();
            this.AgregarArmasCmbox();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int estreno = int.Parse(this.dupEstreno.Text);
            
            ENacionalidad nacionalidadSeleccionada = (ENacionalidad)base.cmbNacionalidad.SelectedItem;

            string actorSeleccionado = cmbActorPrincipal.SelectedItem?.ToString() ?? "Desconocido";
            string armaSeleccionada = cmbArmas.SelectedItem?.ToString() ?? "No encontrada";
            //double precio = double.Parse(this.txtPrecio.Text);


            if (base.CargarFormulario())
            {
                this.peli = new PeliculaAccion(base.txtTitulo.Text, estreno, base.txtDirector.Text, 
                    nacionalidadSeleccionada, actorSeleccionado,armaSeleccionada);
                this.DialogResult = DialogResult.OK;
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

        //private void AgregarEstrenosDup()
        //{
        //    for (int i = 1990; i <= 2023; i++)
        //    {
        //        this.dupEstreno.Items.Add(i.ToString());
        //    }

        //}
    }
}
