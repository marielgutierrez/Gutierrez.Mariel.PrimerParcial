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
            txtTitulo = new TextBox();
            txtDuracion = new TextBox();
            txtAño = new TextBox();
            lstPeliculas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(90, 217);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(182, 23);
            cmbGenero.TabIndex = 0;
            // 
            // btnCrearPeli
            // 
            btnCrearPeli.Location = new Point(110, 322);
            btnCrearPeli.Name = "btnCrearPeli";
            btnCrearPeli.Size = new Size(189, 23);
            btnCrearPeli.TabIndex = 1;
            btnCrearPeli.Text = "Crear Pelicula";
            btnCrearPeli.UseVisualStyleBackColor = true;
            btnCrearPeli.Click += btnCrearPeli_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(74, 79);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 2;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(51, 125);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(100, 23);
            txtDuracion.TabIndex = 3;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(51, 174);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 4;
            // 
            // lstPeliculas
            // 
            lstPeliculas.FormattingEnabled = true;
            lstPeliculas.ItemHeight = 15;
            lstPeliculas.Location = new Point(481, 79);
            lstPeliculas.Name = "lstPeliculas";
            lstPeliculas.Size = new Size(208, 214);
            lstPeliculas.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(469, 39);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 6;
            label1.Text = "Mis Peliculas";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(label1);
            Controls.Add(lstPeliculas);
            Controls.Add(txtAño);
            Controls.Add(txtDuracion);
            Controls.Add(txtTitulo);
            Controls.Add(btnCrearPeli);
            Controls.Add(cmbGenero);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGenero;
        private Button btnCrearPeli;
        private TextBox txtTitulo;
        private TextBox txtDuracion;
        private TextBox txtAño;
        private ListBox lstPeliculas;
        private Label label1;
    }
}