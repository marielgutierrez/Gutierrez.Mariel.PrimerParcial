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
    /// <summary>
    /// Formulario que maneja las opciones del CRUD
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        protected MisPeliculas mispeliculas;

        private static string rutaConfiguracion;
        public static string path = Environment.CurrentDirectory;

        static FrmPrincipal()
        {
            FrmPrincipal.rutaConfiguracion = FrmPrincipal.path + @"\Peliculas.xml";
        }

        /// <summary>
        /// Inicializa todos los elementos del form
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            this.cmbGenero.Items.Add("Acción");
            this.cmbGenero.Items.Add("Comedia");
            this.cmbGenero.Items.Add("Terror");

            this.cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Text = "Crea tu pelicula";
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\pelis_fondito.jpg");
            this.BackgroundImage = img;

            this.mispeliculas = new MisPeliculas();
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
                //titulo (estreno) - nacionalidad ---> (lo q me devuelve el metodo)
                this.lstPeliculas.Items.Add(pelicula.Mostrar());
            }
        }
        /// <summary>
        /// Se encarga de deserializar el archivo si existe 
        /// y mostrar el contenido en el visualizador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(FrmPrincipal.rutaConfiguracion))
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
        }

        /// <summary>
        /// Cuando el usuario hace click en el boton Crear, 
        /// se muestra el formulario correspondiente 
        /// al tipo de pelicula que se selecciono y 
        /// se agrega la pelicula de dicho tipo a la lista de peliculas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearPeli_Click(object sender, EventArgs e)
        {
            if (this.cmbGenero.SelectedItem != null)
            {
                switch (this.cmbGenero.SelectedItem.ToString())
                {
                    case "Acción":
                        FormPeliculaAccion frmPeliAccion = new FormPeliculaAccion();
                        frmPeliAccion.ShowDialog();

                        if (frmPeliAccion.DialogResult == DialogResult.OK)
                        {
                            this.mispeliculas += frmPeliAccion.peli;
                            this.ActualizarVisor();
                        }
                        break;
                    case "Comedia":
                        FormPeliculaComedia frmPeliComedia = new FormPeliculaComedia();
                        frmPeliComedia.ShowDialog();

                        if (frmPeliComedia.DialogResult == DialogResult.OK)
                        {
                            this.mispeliculas += frmPeliComedia.peli;
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
        }

        /// <summary>
        /// Permite que el usuario pueda modificar 
        /// los datos de la pelicula seleccionada
        /// teniendo en cuenta el tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        this.ActualizarVisor();
                    }
                }
                else if (p is PeliculaComedia)
                {
                    FormPeliculaComedia frm1 = new FormPeliculaComedia((PeliculaComedia)p);
                    frm1.ShowDialog();

                    if (frm1.DialogResult == DialogResult.OK)
                    {
                        this.mispeliculas.Peliculas[indice] = frm1.peli;
                        this.ActualizarVisor();
                    }
                }
                else if (p is PeliculaTerror)
                {
                    FormPeliculaTerror frm2 = new FormPeliculaTerror((PeliculaTerror)p);
                    frm2.ShowDialog();

                    if (frm2.DialogResult == DialogResult.OK)
                    {
                        this.mispeliculas.Peliculas[indice] = frm2.peli;
                        this.ActualizarVisor();
                    }
                }
            }
        }

        /// <summary>
        /// Se encarga de verificar el formato del archivo.
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <returns>true si el formato es correcto y no es nulo ni esta vacio, de lo contrario false</returns>
        private bool VerificarFormatoXml(string rutaArchivo)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(rutaArchivo))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Pelicula>));
                    var peliculas = (List<Pelicula>)serializador.Deserialize(reader);

                    return peliculas != null && peliculas.Count > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Intenta leer el archivo xml con la colección, 
        /// la lista actual va a ser el contenido del archivo 
        /// si no pudo se muestra un mensaje.
        /// </summary>
        private void LeerXml()
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(FrmPrincipal.rutaConfiguracion))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Pelicula>));
                    this.mispeliculas.Peliculas = (List<Pelicula>)serializador.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se encarga de importar un archivo desde el directorio que el usuario elija, 
        /// tiene que contener la colección genérica.
        /// En caso de no poder se muestra un mensaje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos XML (*.xml)|*.xml"; //descripcion del tipo de arch | filtro real * cualquier caracter antes
                openFileDialog.InitialDirectory = FrmPrincipal.rutaConfiguracion;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    
                    if(VerificarFormatoXml(path))
                    {
                        FrmPrincipal.rutaConfiguracion = path;
                        this.LeerXml();
                        this.ActualizarVisor();
                        MessageBox.Show("El archivo se importó con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("El archivo no contiene el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error de entrada/salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se encarga de escribir el archivo xml con la colección genérica.
        /// Si no pudo se muestra un mensaje indicando el error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(rutaConfiguracion))
                {
                    DialogResult resultado = MessageBox.Show("El archivo ya existe. ¿Desea sobrescribirlo?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                }

                using (XmlTextWriter writer = new XmlTextWriter(FrmPrincipal.rutaConfiguracion, Encoding.UTF8))
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
        }

        /// <summary>
        /// Se encarga de eliminar de la colección la pelicula seleccionada por el usuario.
        /// Muestra un mensaje de cual se eliminó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    this.mispeliculas -= p;

                    MessageBox.Show($"Se eliminó: {p.Titulo} ({p.Estreno})", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ya no se visualiza en el listbox
                    this.ActualizarVisor();
                }
            }
        }
        /// <summary>
        /// Se encarga del cierre del formulario,
        /// con posibilidad de cancelar el cierre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cuando se apriete el boton correspondiente, se encarga de ordenar 
        /// la colección por titulo de la pelicula de forma Ascendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarTituloA_Click(object sender, EventArgs e)
        {
            this.mispeliculas.Peliculas.Sort(MisPeliculas.OrdenarPorTituloAscendente);
            this.ActualizarVisor();
        }
        /// <summary>
        /// Cuando se apriete el boton correspondiente, se encarga de ordenar 
        /// la colección por titulo de la pelicula de forma Descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarTituloD_Click(object sender, EventArgs e)
        {
            this.mispeliculas.Peliculas.Sort(MisPeliculas.OrdenarPorTituloDescendente);
            this.ActualizarVisor();
        }
        /// <summary>
        /// Cuando se apriete el boton correspondiente, se encarga de ordenar 
        /// la colección por estreno (año) de la pelicula de forma Ascendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarEstrenoA_Click(object sender, EventArgs e)
        {
            this.mispeliculas.Peliculas.Sort(MisPeliculas.OrdenarPorEstrenoAscendente);
            this.ActualizarVisor();
        }
        /// <summary>
        /// Cuando se apriete el boton correspondiente, se encarga de ordenar 
        /// la colección por estreno (año) de la pelicula de forma Descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarEstrenoD_Click(object sender, EventArgs e)
        {
            this.mispeliculas.Peliculas.Sort(MisPeliculas.OrdenarPorEstrenoDescendente);
            this.ActualizarVisor();
        }
    }
}
