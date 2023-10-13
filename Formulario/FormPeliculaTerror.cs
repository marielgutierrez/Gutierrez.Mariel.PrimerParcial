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
    public partial class FormPeliculaTerror : FormPeliculas
    {
        public FormPeliculaTerror()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }




        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if (base.CargarFormulario())
            //{
            //    this.alumnito = new Alumno(base.txtNombre.Text, base.txtApellido.Text, int.Parse(base.txtDni.Text),
            //                        int.Parse(this.txtNotaUno.Text), int.Parse(this.txtNotaDos.Text), int.Parse(this.txtNotaTres.Text));
            //    this.DialogResult = DialogResult.OK;
            //}
        }
    }
}
