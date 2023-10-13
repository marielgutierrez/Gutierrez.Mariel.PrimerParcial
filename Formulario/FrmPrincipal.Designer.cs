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
            lblUsuario = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(75, 117);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(204, 23);
            cmbGenero.TabIndex = 0;
            // 
            // btnCrearPeli
            // 
            btnCrearPeli.Location = new Point(96, 162);
            btnCrearPeli.Name = "btnCrearPeli";
            btnCrearPeli.Size = new Size(146, 36);
            btnCrearPeli.TabIndex = 1;
            btnCrearPeli.Text = "Crear Pelicula";
            btnCrearPeli.UseVisualStyleBackColor = true;
            btnCrearPeli.Click += btnCrearPeli_Click;
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
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 79);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 8;
            label2.Text = "Seleccione un tipo de pelicula:";
            // 
            // button1
            // 
            button1.Location = new Point(602, 376);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 9;
            button1.Text = "Salir de la App";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 436);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(lstPeliculas);
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
        private ListBox lstPeliculas;
        private Label label1;
        private Label lblUsuario;
        private Label label2;
        private Button button1;
    }
}