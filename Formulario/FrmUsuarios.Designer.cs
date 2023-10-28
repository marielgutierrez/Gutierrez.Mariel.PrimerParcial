namespace Formulario
{
    partial class FrmUsuarios
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
            lstUsuarios = new ListBox();
            SuspendLayout();
            // 
            // lstUsuarios
            // 
            lstUsuarios.BackColor = SystemColors.MenuText;
            lstUsuarios.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsuarios.ForeColor = SystemColors.Info;
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(19, 29);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(922, 349);
            lstUsuarios.TabIndex = 0;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pelis_fondito2;
            ClientSize = new Size(961, 399);
            Controls.Add(lstUsuarios);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstUsuarios;
    }
}