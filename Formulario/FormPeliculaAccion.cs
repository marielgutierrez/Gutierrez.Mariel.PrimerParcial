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
    public partial class FormPeliculaAccion : FormPeliculas
    {
        public FormPeliculaAccion()
        {
            InitializeComponent();


            btnCancelar.Click += btnCancelar_Click;
        }
    }
}
