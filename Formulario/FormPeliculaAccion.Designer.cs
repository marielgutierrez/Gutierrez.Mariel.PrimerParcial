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
            cmbArmas = new ComboBox();
            cmbActorPrincipal = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            groupBox2.SuspendLayout();
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
            groupBox2.Controls.Add(cmbArmas);
            groupBox2.Controls.Add(cmbActorPrincipal);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(28, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Características";
            // 
            // cmbArmas
            // 
            cmbArmas.FormattingEnabled = true;
            cmbArmas.Location = new Point(123, 73);
            cmbArmas.Name = "cmbArmas";
            cmbArmas.Size = new Size(180, 23);
            cmbArmas.TabIndex = 8;
            // 
            // cmbActorPrincipal
            // 
            cmbActorPrincipal.FormattingEnabled = true;
            cmbActorPrincipal.Location = new Point(123, 32);
            cmbActorPrincipal.Name = "cmbActorPrincipal";
            cmbActorPrincipal.Size = new Size(180, 23);
            cmbActorPrincipal.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 76);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 3;
            label11.Text = "Armas:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 35);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 2;
            label10.Text = "Actor principal:";
            // 
            // FormPeliculaAccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 463);
            Controls.Add(groupBox2);
            Name = "FormPeliculaAccion";
            Text = "FormPeliculaAccion";
            Load += FormPeliculaAccion_Load;
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
        private Label label10;
        private Label label11;
        private ComboBox cmbActorPrincipal;
        private ComboBox cmbArmas;
    }
}