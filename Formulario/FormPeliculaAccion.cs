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
    public partial class FormPeliculaAccion : FormPeliculas
    {
        public Entidades.PeliculaAccion peli;

        public FormPeliculaAccion(Entidades.PeliculaAccion p) : this()
        {
            this.txtTitulo.Text = p.Titulo;
            //this.txt.Text = p.Estreno.ToString;
            //this.txtPrecio.Text = p.Duracion.ToString();
            //this.txtCodigo.Enabled = false;
        }


        public FormPeliculaAccion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //btnCancelar.Click += btnCancelar_Click;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //int estreno = int.Parse(this.txtCodigo.Text);
            //string titulo = base.txtTitulo.Text;
            //double precio = double.Parse(this.txtPrecio.Text);


            //if (base.CargarFormulario())
            //{
            //    this.alumnito = new PeliculaAccion(base.txtTitulo.Text, base.txtEstreno.Text, int.Parse(base.txtDni.Text),
            //                        int.Parse(this.txtNotaUno.Text), int.Parse(this.txtNotaDos.Text), int.Parse(this.txtNotaTres.Text));
            //    this.DialogResult = DialogResult.OK;
            //}
        }
    }
}
