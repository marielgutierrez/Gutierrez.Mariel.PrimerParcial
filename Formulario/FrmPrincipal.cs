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
        protected MisPeliculas mispeliculas;

        public FrmPrincipal()
        {
            InitializeComponent();
            cmbGenero.Items.Add("Acción");
            cmbGenero.Items.Add("Comedia");
            cmbGenero.Items.Add("Terror");

            this.mispeliculas = new MisPeliculas();
        }

        public FrmPrincipal(Usuario u) : this()
        {
            lblUsuario.Text = $"Bienvenido {u.nombre} - [{DateTime.Now.ToString("dd/MM/yyyy")}]";
        }

        /// <summary>
        /// Se encarga de limpiar y recorrer la lista de peliculas 
        /// para actualizar la info del visor
        /// </summary>
        private void ActualizarVisor()
        {
            this.lstPeliculas.Items.Clear();
            foreach (Pelicula pelicula in this.mispeliculas.Peliculas)
            {
                //agrega la info de cada peli que estoy recorriendo
                //titulo - (estreno) ---> (lo q me devuelve el metodo ToString)
                lstPeliculas.Items.Add(pelicula.Mostrar());
            }
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
                        frmpeliaccion.ShowDialog();
                        break;
                    case "Comedia":
                        FormPeliculaComedia frmpelicomedia = new FormPeliculaComedia();
                        frmpelicomedia.ShowDialog();
                        break;
                    case "Terror":
                        FormPeliculaTerror frmpeliterror = new FormPeliculaTerror();
                        frmpeliterror.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de pelicula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
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
            */
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstPeliculas.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Se debe seleccionar una pelicula de la lista");
            }
            else if (lstPeliculas == null && indice == -1)
            {
                MessageBox.Show("Debe crear una pelicula y agregarla a la lista");
            }

            Pelicula p = this.mispeliculas.Peliculas[indice];

            //if (p is PeliculaAccion)
            //{
            //    FormPeliculaAccion frm = new FormPeliculaAccion(p);
            //    frm.ShowDialog();

            //    if (frm.DialogResult == DialogResult.OK)
            //    {
            //        // pisa el objeto orginal por el obj ya modificado
            //        this.mispeliculas.Peliculas[indice] = frm.pelicula; ///ver en el form correspondiente
            //        //que se visualice en el listbox
            //        this.ActualizarVisor();
            //    }

            //}
            //else if (p is PeliculaComedia)
            //{
            //    FormPeliculaComedia frm1 = new FormPeliculaComedia(p);
            //    frm1.ShowDialog();

            //    if (frm1.DialogResult == DialogResult.OK)
            //    {
            //        // pisa el objeto orginal por el obj ya modificado
            //        this.mispeliculas.Peliculas[indice] = frm1.pelicula; ///ver en el form correspondiente
            //        //que se visualice en el listbox
            //        this.ActualizarVisor();
            //    }
            //}
            //else if (p is PeliculaTerror)
            //{
            //    FormPeliculaTerror frm2 = new FormPeliculaTerror(p);
            //    frm2.ShowDialog();

            //    if (frm2.DialogResult == DialogResult.OK)
            //    {
            //        // pisa el objeto orginal por el obj ya modificado
            //        this.mispeliculas.Peliculas[indice] = frm2.pelicula; ///ver en el form correspondiente
            //        //que se visualice en el listbox
            //        this.ActualizarVisor();
            //    }
            //}


            //le paso "p" por parametro para que me cargue los datos del producto seleccionado en el nuevo form
            //se muestra mi formulario
        }
    }
}
