namespace Formulario
{
    partial class FormPeliculaAccion
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
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Click += btnAceptar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(350, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 205);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Características";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(243, 109);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(52, 19);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "Balas";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(143, 109);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(87, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Explosiones";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(143, 71);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(158, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(143, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 23);
            comboBox2.TabIndex = 7;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(243, 149);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(61, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Pistola";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(188, 149);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(49, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Rifle";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(109, 149);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Escopeta";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 150);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 3;
            label11.Text = "Armas:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 35);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 2;
            label10.Text = "Actor principal:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 111);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 1;
            label9.Text = "Efectos especiales:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 74);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 0;
            label8.Text = "Escenas de acción:";
            // 
            // FormPeliculaAccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 383);
            Controls.Add(groupBox2);
            Name = "FormPeliculaAccion";
            Text = "FormPeliculaAccion";
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(groupBox2, 0);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private CheckBox checkBox1;
        private Label label11;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}