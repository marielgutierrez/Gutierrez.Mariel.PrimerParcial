﻿namespace Formulario
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
            label9 = new Label();
            cmbPersonaje = new ComboBox();
            cmbTerror = new ComboBox();
            label8 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // 
            // btnAceptar
            // 
            btnAceptar.Click += btnAceptar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbPersonaje);
            groupBox2.Controls.Add(cmbTerror);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(28, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 127);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Características";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 35);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 3;
            label9.Text = "Tipo de terror:";
            // 
            // cmbPersonaje
            // 
            cmbPersonaje.FormattingEnabled = true;
            cmbPersonaje.Location = new Point(123, 80);
            cmbPersonaje.Name = "cmbPersonaje";
            cmbPersonaje.Size = new Size(180, 23);
            cmbPersonaje.TabIndex = 2;
            // 
            // cmbTerror
            // 
            cmbTerror.FormattingEnabled = true;
            cmbTerror.Location = new Point(123, 32);
            cmbTerror.Name = "cmbTerror";
            cmbTerror.Size = new Size(180, 23);
            cmbTerror.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 83);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 0;
            label8.Text = "Personaje principal:";
            // 
            // FormPeliculaTerror
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 470);
            Controls.Add(groupBox2);
            Name = "FormPeliculaTerror";
            Text = "FormPeliculaTerror";
            Load += FormPeliculaTerror_Load;
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
        private ComboBox cmbTerror;
        private Label label8;
        private Label label9;
        private ComboBox cmbPersonaje;
    }
}