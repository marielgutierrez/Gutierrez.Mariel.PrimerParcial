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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(86, 86);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(204, 23);
            cmbGenero.TabIndex = 0;
            // 
            // btnCrearPeli
            // 
            btnCrearPeli.Location = new Point(118, 131);
            btnCrearPeli.Name = "btnCrearPeli";
            btnCrearPeli.Size = new Size(146, 36);
            btnCrearPeli.TabIndex = 1;
            btnCrearPeli.Text = "Crear";
            btnCrearPeli.UseVisualStyleBackColor = true;
            btnCrearPeli.Click += btnCrearPeli_Click;
            // 
            // lstPeliculas
            // 
            lstPeliculas.FormattingEnabled = true;
            lstPeliculas.ItemHeight = 15;
            lstPeliculas.Location = new Point(377, 79);
            lstPeliculas.Name = "lstPeliculas";
            lstPeliculas.Size = new Size(297, 214);
            lstPeliculas.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(468, 42);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 6;
            label1.Text = "Mis Peliculas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 48);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 8;
            label2.Text = "Seleccione un tipo de pelicula:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(377, 309);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(377, 349);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 309);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(550, 349);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(124, 23);
            btnImportar.TabIndex = 12;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cartel_info;
            pictureBox1.Location = new Point(86, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 255);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 436);
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
            PerformLayout();
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
    }
}