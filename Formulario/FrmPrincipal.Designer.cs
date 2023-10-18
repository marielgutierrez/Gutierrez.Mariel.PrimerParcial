namespace Formulario
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbGenero = new ComboBox();
            btnCrearPeli = new Button();
            lstPeliculas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnImportar = new Button();
            pictureBox1 = new PictureBox();
            btnOrdenarTituloA = new Button();
            btnOrdenarTituloD = new Button();
            btnOrdenarEstrenoA = new Button();
            btnOrdenarEstrenoD = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(41, 82);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(204, 23);
            cmbGenero.TabIndex = 0;
            // 
            // btnCrearPeli
            // 
            btnCrearPeli.Location = new Point(41, 127);
            btnCrearPeli.Name = "btnCrearPeli";
            btnCrearPeli.Size = new Size(204, 36);
            btnCrearPeli.TabIndex = 1;
            btnCrearPeli.Text = "Crear";
            btnCrearPeli.UseVisualStyleBackColor = true;
            btnCrearPeli.Click += btnCrearPeli_Click;
            // 
            // lstPeliculas
            // 
            lstPeliculas.FormattingEnabled = true;
            lstPeliculas.ItemHeight = 15;
            lstPeliculas.Location = new Point(335, 82);
            lstPeliculas.Name = "lstPeliculas";
            lstPeliculas.Size = new Size(297, 214);
            lstPeliculas.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(375, 44);
            label1.Name = "label1";
            label1.Size = new Size(236, 35);
            label1.TabIndex = 6;
            label1.Text = "Mis Peliculas";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(30, 44);
            label2.Name = "label2";
            label2.Size = new Size(234, 26);
            label2.TabIndex = 8;
            label2.Text = "Seleccione un tipo de pelicula:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(335, 312);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 39);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(335, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 38);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(508, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 39);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(508, 362);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(124, 39);
            btnImportar.TabIndex = 12;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cartel_info;
            pictureBox1.Location = new Point(41, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnOrdenarTituloA
            // 
            btnOrdenarTituloA.Location = new Point(656, 82);
            btnOrdenarTituloA.Name = "btnOrdenarTituloA";
            btnOrdenarTituloA.Size = new Size(85, 39);
            btnOrdenarTituloA.TabIndex = 14;
            btnOrdenarTituloA.Text = "Ordenar de  A-Z";
            btnOrdenarTituloA.UseVisualStyleBackColor = true;
            btnOrdenarTituloA.Click += btnOrdenarTituloA_Click;
            // 
            // btnOrdenarTituloD
            // 
            btnOrdenarTituloD.Location = new Point(656, 127);
            btnOrdenarTituloD.Name = "btnOrdenarTituloD";
            btnOrdenarTituloD.Size = new Size(85, 39);
            btnOrdenarTituloD.TabIndex = 15;
            btnOrdenarTituloD.Text = "Ordenar de  Z-A";
            btnOrdenarTituloD.UseVisualStyleBackColor = true;
            btnOrdenarTituloD.Click += btnOrdenarTituloD_Click;
            // 
            // btnOrdenarEstrenoA
            // 
            btnOrdenarEstrenoA.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenarEstrenoA.Location = new Point(656, 181);
            btnOrdenarEstrenoA.Name = "btnOrdenarEstrenoA";
            btnOrdenarEstrenoA.Size = new Size(85, 54);
            btnOrdenarEstrenoA.TabIndex = 16;
            btnOrdenarEstrenoA.Text = "Ordenar por año ascendente";
            btnOrdenarEstrenoA.UseVisualStyleBackColor = true;
            btnOrdenarEstrenoA.Click += btnOrdenarEstrenoA_Click;
            // 
            // btnOrdenarEstrenoD
            // 
            btnOrdenarEstrenoD.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenarEstrenoD.Location = new Point(656, 250);
            btnOrdenarEstrenoD.Name = "btnOrdenarEstrenoD";
            btnOrdenarEstrenoD.Size = new Size(85, 62);
            btnOrdenarEstrenoD.TabIndex = 17;
            btnOrdenarEstrenoD.Text = "Ordenar por año descendente";
            btnOrdenarEstrenoD.UseVisualStyleBackColor = true;
            btnOrdenarEstrenoD.Click += btnOrdenarEstrenoD_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pelis_fondito;
            ClientSize = new Size(773, 436);
            Controls.Add(btnOrdenarEstrenoD);
            Controls.Add(btnOrdenarEstrenoA);
            Controls.Add(btnOrdenarTituloD);
            Controls.Add(btnOrdenarTituloA);
            Controls.Add(pictureBox1);
            Controls.Add(btnImportar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPeliculas);
            Controls.Add(btnCrearPeli);
            Controls.Add(cmbGenero);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbGenero;
        private Button btnCrearPeli;
        private ListBox lstPeliculas;
        private Label label1;
        private Label label2;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnImportar;
        private PictureBox pictureBox1;
        private Button btnOrdenarTituloA;
        private Button btnOrdenarTituloD;
        private Button btnOrdenarEstrenoA;
        private Button btnOrdenarEstrenoD;
    }
}