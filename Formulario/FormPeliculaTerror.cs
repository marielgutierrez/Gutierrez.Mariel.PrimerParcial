﻿using System;
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
            btnCancelar.Click += btnCancelar_Click;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
