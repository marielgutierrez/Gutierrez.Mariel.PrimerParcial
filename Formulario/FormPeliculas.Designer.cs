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
            label1 = new Label();
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            dupEstreno = new DomainUpDown();
            txtDirector = new TextBox();
            label6 = new Label();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 8;
            label1.Text = "Crear Pelicula";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LimeGreen;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(212, 327);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 45);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dupEstreno);
            groupBox1.Controls.Add(txtDirector);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 239);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 23;
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
            // dupEstreno
            // 
            dupEstreno.BorderStyle = BorderStyle.FixedSingle;
            dupEstreno.Location = new Point(123, 67);
            dupEstreno.Name = "dupEstreno";
            dupEstreno.Size = new Size(180, 23);
            dupEstreno.TabIndex = 21;
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(178, 192);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(122, 192);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sí";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 194);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 13;
            label4.Text = "Subtítulos:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(380, 327);
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
            ClientSize = new Size(674, 387);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPeliculas";
            Text = "FormPeliculas";
            Load += FormPeliculas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        protected Button btnCancelar;
        protected Button btnAceptar;
        protected TextBox txtTitulo;
        protected TextBox txtDirector;
        protected RadioButton radioButton2;
        protected RadioButton radioButton1;
        protected DomainUpDown dupEstreno;
        protected ComboBox comboBox1;
    }
}