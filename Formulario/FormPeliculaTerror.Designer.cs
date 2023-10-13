namespace Formulario
{
    partial class FormPeliculaTerror
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
            checkBox1 = new CheckBox();
            radioButton3 = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(361, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 238);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Características";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(232, 133);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(41, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "No";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(143, 170);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 7;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(172, 133);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(34, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Sí";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 169);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 5;
            label11.Text = "Música de suspenso:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 133);
            label10.Name = "label10";
            label10.Size = new Size(145, 15);
            label10.TabIndex = 4;
            label10.Text = "Elementos sobrenaturales:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 35);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 3;
            label9.Text = "Tipo de terror:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(143, 80);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(155, 23);
            comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(143, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 23);
            comboBox2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 88);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 0;
            label8.Text = "Personaje principal:";
            // 
            // FormPeliculaTerror
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(groupBox2);
            Name = "FormPeliculaTerror";
            Text = "FormPeliculaTerror";
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(groupBox2, 0);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private Label label8;
        private Label label10;
        private Label label9;
        private ComboBox comboBox3;
        private Label label11;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private CheckBox checkBox1;
    }
}