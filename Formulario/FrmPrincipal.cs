using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmPrincipal : Form
    {
        protected MisPeliculas mispeliculas;

        private static string rutaConfiguracion;
        public static string path = Environment.CurrentDirectory;

        static FrmPrincipal()
        {
            FrmPrincipal.rutaConfiguracion = FrmPrincipal.path + @"\Peliculas.json";
        }

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
            if (File.Exists(FrmPrincipal.rutaConfiguracion))
            {
                try
                {
                    LeerJson();
                    ActualizarVisor();
                }
                catch (JsonException ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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

                        if (frmpeliaccion.DialogResult == DialogResult.OK)
                        {
                            mispeliculas += frmpeliaccion.peli;
                            //que se visualice en el listbox
                            this.ActualizarVisor();
                        }
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
            else
            {
                Pelicula p = this.mispeliculas.Peliculas[indice];

                if (p is PeliculaAccion)
                {
                    FormPeliculaAccion frm = new FormPeliculaAccion((PeliculaAccion)p);
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        // pisa el objeto orginal por el obj ya modificado
                        this.mispeliculas.Peliculas[indice] = frm.peli;
                        //que se visualice en el listbox
                        this.ActualizarVisor();
                    }

                }
                //else if (p is PeliculaComedia)
                //{
                //    FormPeliculaComedia frm1 = new FormPeliculaComedia(p);
                //    frm1.ShowDialog();

                //    if (frm1.DialogResult == DialogResult.OK)
                //    {
                //        // pisa el objeto orginal por el obj ya modificado
                //        this.mispeliculas.Peliculas[indice] = frm1.peliculaC; ///ver en el form correspondiente
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
            }
            /*
               Pelicula p = this.mispeliculas.Peliculas[indice];

            if (p is PeliculaAccion)
            {
                FormPeliculaAccion frm = new FormPeliculaAccion((PeliculaAccion)p);
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    // pisa el objeto orginal por el obj ya modificado
                    this.mispeliculas.Peliculas[indice] = frm.peli;
                    //que se visualice en el listbox
                    this.ActualizarVisor();
                }

            }
            //else if (p is PeliculaComedia)
            //{
            //    FormPeliculaComedia frm1 = new FormPeliculaComedia(p);
            //    frm1.ShowDialog();

            //    if (frm1.DialogResult == DialogResult.OK)
            //    {
            //        // pisa el objeto orginal por el obj ya modificado
            //        this.mispeliculas.Peliculas[indice] = frm1.peliculaC; ///ver en el form correspondiente
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
            */
        }

        private void LeerJson()
        {
            if (File.Exists(path + @"\Peliculas.json"))
            {
                using (StreamReader lectorJson = new StreamReader(path + @"\Peliculas.json"))
                {
                    //string json_str = lectorJson.ReadToEnd();
                    //this.mispeliculas.Peliculas = (List<Pelicula>)JsonSerializer.Deserialize(json_str, typeof(List<Pelicula>));
                    string json_str = lectorJson.ReadToEnd();

                    // Asegúrate de que Pelicula tenga un constructor sin parámetros o usa JsonConverter
                    this.mispeliculas.Peliculas = JsonSerializer.Deserialize<List<Pelicula>>(json_str);
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files(.json)|*.json"; //descripcion del tipo de arch | filtro real * cualquier caracter antes
            openFileDialog.InitialDirectory = rutaConfiguracion;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaConfiguracion = openFileDialog.FileName;
                this.LeerJson();
                this.ActualizarVisor();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true; //da formato JSON

            string objJson = JsonSerializer.Serialize(this.mispeliculas.Peliculas, opciones);

            using (StreamWriter sw = new StreamWriter(path + @"\Peliculas.json"))
            {
                sw.WriteLine(objJson);
            }

            MessageBox.Show("Se guardó la lista con éxito!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstPeliculas.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Se debe seleccionar una pelicula de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea eliminar la pelicula seleccionada?",
                                                           "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    Pelicula p = this.mispeliculas.Peliculas[indice];

                    // elimino la pelicula seleccionada de la lista
                    mispeliculas -= p;

                    //que se visualice en el listbox
                    this.ActualizarVisor();
                }
            }
        }
    }
}
