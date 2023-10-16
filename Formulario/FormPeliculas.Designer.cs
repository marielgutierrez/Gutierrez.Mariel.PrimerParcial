namespace Formulario
{
    partial class FormPeliculas
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
            label2 = new Label();
            txtTitulo = new TextBox();
            lblNombreForm = new Label();
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            nupEstreno = new NumericUpDown();
            cmbNacionalidad = new ComboBox();
            label7 = new Label();
            txtDirector = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupEstreno).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 30);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Location = new Point(123, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(180, 23);
            txtTitulo.TabIndex = 9;
            // 
            // lblNombreForm
            // 
            lblNombreForm.AutoSize = true;
            lblNombreForm.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreForm.Location = new Point(28, 9);
            lblNombreForm.Name = "lblNombreForm";
            lblNombreForm.Size = new Size(140, 30);
            lblNombreForm.TabIndex = 8;
            lblNombreForm.Text = "Crear Película";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LimeGreen;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(45, 399);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 45);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nupEstreno);
            groupBox1.Controls.Add(cmbNacionalidad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDirector);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 187);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // nupEstreno
            // 
            nupEstreno.Location = new Point(123, 67);
            nupEstreno.Name = "nupEstreno";
            nupEstreno.ReadOnly = true;
            nupEstreno.Size = new Size(180, 23);
            nupEstreno.TabIndex = 24;
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Location = new Point(123, 149);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(180, 23);
            cmbNacionalidad.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 152);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 22;
            label7.Text = "Nacionalidad:";
            // 
            // txtDirector
            // 
            txtDirector.BorderStyle = BorderStyle.FixedSingle;
            txtDirector.Location = new Point(123, 109);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(180, 23);
            txtDirector.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 112);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 18;
            label6.Text = "Director:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 69);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 16;
            label5.Text = "Estreno:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(218, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 45);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 456);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(lblNombreForm);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPeliculas";
            Text = "FormPeliculas";
            Load += FormPeliculas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupEstreno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        protected Button btnCancelar;
        protected Button btnAceptar;
        protected TextBox txtTitulo;
        protected TextBox txtDirector;
        protected ComboBox cmbNacionalidad;
        protected NumericUpDown nupEstreno;
        protected Label lblNombreForm;
    }
}