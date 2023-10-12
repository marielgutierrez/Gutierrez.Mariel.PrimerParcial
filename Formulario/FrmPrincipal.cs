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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            cmbGenero.Items.Add("Accion");
            cmbGenero.Items.Add("Comedia");
            cmbGenero.Items.Add("Terror");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPeli_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            int duracion = Convert.ToInt32(txtDuracion.Text);
            int año = Convert.ToInt32(txtAño.Text);


            if (cmbGenero.SelectedItem.ToString() == "Acción")
            {
                FormPeliculaAccion frmpeliaccion = new FormPeliculaAccion();
                frmpeliaccion.ShowDialog();
            }
            else if (cmbGenero.SelectedItem.ToString() == "Comedia")
            {
                //pelicula = new PeliculaComedia { Titulo = titulo, Duracion = duracion, Año = año };
            }
            else
            {
                // En caso de otros géneros o si no se selecciona ninguno, usa la clase base Pelicula
            }

            MessageBox.Show($"Se ha guardado la película:, Género: ");

            //lstPeliculas.Items.Add(pelicula);

            //txtTitulo.Clear();
            //txtDuracion.Clear();
            //txtAño.Clear();
        }

    }
}
