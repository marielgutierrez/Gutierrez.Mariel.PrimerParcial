namespace Formulario
{
    partial class FormPeliculaComedia
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
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(28, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 122);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Características";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 72);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 1;
            label9.Text = "Actor Principal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 34);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 0;
            label8.Text = "Tipo de comedia:";
            label8.Click += label8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(123, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 23);
            comboBox2.TabIndex = 4;
            // 
            // FormPeliculaComedia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 462);
            Controls.Add(groupBox2);
            Name = "FormPeliculaComedia";
            Text = "FormPelisComedia";
            Load += FormPelisComedia_Load;
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(groupBox2, 0);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}