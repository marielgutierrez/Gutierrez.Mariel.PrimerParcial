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
using System.Xml.Serialization;
using System.Xml;

namespace Formulario
{
    public partial class FrmPrincipal : Form
    {
        protected MisPeliculas mispeliculas;

        private static string rutaConfiguracion;
        public static string path = Environment.CurrentDirectory;

        static FrmPrincipal()
        {
            FrmPrincipal.rutaConfiguracion = FrmPrincipal.path + @"\Peliculas.xml";
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
            try
            {
                if (File.Exists(path + @"\Peliculas.xml"))
                {
                    /* Si existe el archivo lo lee y actualiza la tabla */
                    this.LeerXml();
                    this.ActualizarVisor();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al importar archivo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
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
            */
        }

        private void btnCrearPeli_Click(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedItem != null)
            {
                switch (cmbGenero.SelectedItem.ToString())
                {
                    case "Acción":
                        FormPeliculaAccion frmPeliAccion = new FormPeliculaAccion();
                        frmPeliAccion.ShowDialog();

                        if (frmPeliAccion.DialogResult == DialogResult.OK)
                        {
                            this.mispeliculas += frmPeliAccion.peli;
                            //que se visualice en el listbox
                            this.ActualizarVisor();
                        }
                        break;
                    case "Comedia":
                        FormPeliculaComedia frmPeliComedia = new FormPeliculaComedia();
                        frmPeliComedia.ShowDialog();

                        if (frmPeliComedia.DialogResult == DialogResult.OK)
                        {
                            this.mispeliculas += frmPeliComedia.peli;
                            //que se visualice en el listbox
                            this.ActualizarVisor();
                        }
                        break;
                    case "Terror":
                        FormPeliculaTerror frmPeliTerror = new FormPeliculaTerror();
                        frmPeliTerror.ShowDialog();
                        if (frmPeliTerror.DialogResult == DialogResult.OK)
                        {
                            this.mispeliculas += frmPeliTerror.peli;
                            //que se visualice en el listbox
                            this.ActualizarVisor();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de pelicula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //MessageBox.Show($"Se ha guardado la película:, Género: ");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstPeliculas.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Se debe seleccionar una pelicula de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (p is PeliculaComedia)
                {
                    FormPeliculaComedia frm1 = new FormPeliculaComedia((PeliculaComedia)p);
                    frm1.ShowDialog();

                    if (frm1.DialogResult == DialogResult.OK)
                    {
                        // pisa el objeto orginal por el obj ya modificado
                        this.mispeliculas.Peliculas[indice] = frm1.peli; ///ver en el form correspondiente
                        //que se visualice en el listbox
                        this.ActualizarVisor();
                    }
                }
                else if (p is PeliculaTerror)
                {
                    FormPeliculaTerror frm2 = new FormPeliculaTerror((PeliculaTerror)p);
                    frm2.ShowDialog();

                    if (frm2.DialogResult == DialogResult.OK)
                    {
                        // pisa el objeto orginal por el obj ya modificado
                        this.mispeliculas.Peliculas[indice] = frm2.peli; ///ver en el form correspondiente
                        //que se visualice en el listbox
                        this.ActualizarVisor();
                    }
                }
            }
            //le paso "p" por parametro para que me cargue los datos del producto seleccionado en el nuevo form
            //se muestra mi formulario
        }

        private void LeerXml()
        {
            using (XmlTextReader reader = new XmlTextReader(path + @"\Peliculas.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Pelicula>));

                this.mispeliculas.Peliculas = (List<Pelicula>)serializador.Deserialize(reader);
            }
            /*
            //if (File.Exists(path + @"\Peliculas.json"))
            //{
            //    using (StreamReader lectorJson = new StreamReader(path + @"\Peliculas.json"))
            //    {
            //        //string json_str = lectorJson.ReadToEnd();
            //        //this.mispeliculas.Peliculas = (List<Pelicula>)JsonSerializer.Deserialize(json_str, typeof(List<Pelicula>));
            //        string json_str = lectorJson.ReadToEnd();

            //        // Asegúrate de que Pelicula tenga un constructor sin parámetros o usa JsonConverter
            //        this.mispeliculas.Peliculas = JsonSerializer.Deserialize<List<Pelicula>>(json_str);
            //    }
            //}
            */
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos XML (*.xml)|*.xml"; //descripcion del tipo de arch | filtro real * cualquier caracter antes
                openFileDialog.InitialDirectory = rutaConfiguracion;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaConfiguracion = openFileDialog.FileName;
                    this.LeerXml();
                    this.ActualizarVisor();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error de entrada/salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path + @"\Peliculas.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Pelicula>));
                    serializador.Serialize(writer, this.mispeliculas.Peliculas);
                }

                MessageBox.Show("Se guardó el archivo con éxito!");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error de entrada/salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*
            //JsonSerializerOptions opciones = new JsonSerializerOptions();
            //opciones.WriteIndented = true; //da formato JSON

            //string objJson = JsonSerializer.Serialize(this.mispeliculas.Peliculas, opciones);

            //using (StreamWriter sw = new StreamWriter(path + @"\Peliculas.json"))
            //{
            //    sw.WriteLine(objJson);
            //}
            */
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
                DialogResult confirmacion = MessageBox.Show("¿Desea eliminar de la lista la pelicula seleccionada?",
                                                           "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    Pelicula p = this.mispeliculas.Peliculas[indice];

                    // elimino la pelicula seleccionada de la lista
                    mispeliculas -= p;

                    MessageBox.Show($"Se eliminó {p.Titulo} ({p.Estreno})", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //que se visualice en el listbox
                    this.ActualizarVisor();
                }
            }
        }
    }
}
