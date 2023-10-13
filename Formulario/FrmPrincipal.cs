using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            cmbGenero.Items.Add("Acción");
            cmbGenero.Items.Add("Comedia");
            cmbGenero.Items.Add("Terror");
        }

        public FrmPrincipal(Usuario u) : this()
        {
            lblUsuario.Text = $"Bienvenido {u.nombre} - [{DateTime.Now.ToString("dd/MM/yyyy")}]";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPeli_Click(object sender, EventArgs e)
        {
            //string titulo = txtTitulo.Text;
            //int duracion = Convert.ToInt32(txtDuracion.Text);
            //int año = Convert.ToInt32(txtAño.Text);
            if (cmbGenero.SelectedItem != null)
            {
                switch (cmbGenero.SelectedItem.ToString())
                {
                    case "Acción":
                        FormPeliculaAccion frmpeliaccion = new FormPeliculaAccion();
                        frmpeliaccion.StartPosition = FormStartPosition.CenterScreen;
                        frmpeliaccion.ShowDialog();
                        break;
                    case "Comedia":
                        FormPeliculaComedia frmpelicomedia = new FormPeliculaComedia();
                        frmpelicomedia.StartPosition = FormStartPosition.CenterScreen;
                        frmpelicomedia.ShowDialog();
                        break;
                    case "Terror":
                        FormPeliculaTerror frmpeliterror = new FormPeliculaTerror();
                        frmpeliterror.StartPosition = FormStartPosition.CenterScreen;
                        frmpeliterror.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de pelicula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (cmbGenero.SelectedItem.ToString() == "Acción")
            //{
            //    FormPeliculaAccion frmpeliaccion = new FormPeliculaAccion();
            //    frmpeliaccion.StartPosition = FormStartPosition.CenterScreen;

            //    frmpeliaccion.ShowDialog();

            //}
            //else if (cmbGenero.SelectedItem.ToString() == "Comedia")
            //{
            //    FormPeliculaComedia frmpelicomedia = new FormPeliculaComedia();
            //    frmpelicomedia.StartPosition = FormStartPosition.CenterScreen;
            //    frmpelicomedia.ShowDialog();
            //    //pelicula = new PeliculaComedia { Titulo = titulo, Duracion = duracion, Año = año };
            //}
            //else 
            //{
            //    FormPeliculaTerror frmpeliterror = new FormPeliculaTerror();
            //    frmpeliterror.StartPosition = FormStartPosition.CenterScreen;
            //    frmpeliterror.ShowDialog();
            //}

            //MessageBox.Show($"Se ha guardado la película:, Género: ");

            //lstPeliculas.Items.Add(pelicula);

            //txtTitulo.Clear();
            //txtDuracion.Clear();
            //txtAño.Clear();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
