namespace Formulario
{
    partial class FrmMDI
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
            menuStrip1 = new MenuStrip();
            peliculasToolStripMenuItem = new ToolStripMenuItem();
            misPeliculasToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            verUsuariosToolStripMenuItem = new ToolStripMenuItem();
            lblUsuario = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { peliculasToolStripMenuItem, usuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // peliculasToolStripMenuItem
            // 
            peliculasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { misPeliculasToolStripMenuItem });
            peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            peliculasToolStripMenuItem.Size = new Size(65, 20);
            peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // misPeliculasToolStripMenuItem
            // 
            misPeliculasToolStripMenuItem.Name = "misPeliculasToolStripMenuItem";
            misPeliculasToolStripMenuItem.Size = new Size(142, 22);
            misPeliculasToolStripMenuItem.Text = "Mis Peliculas";
            misPeliculasToolStripMenuItem.Click += misPeliculasToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verUsuariosToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // verUsuariosToolStripMenuItem
            // 
            verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            verUsuariosToolStripMenuItem.Size = new Size(138, 22);
            verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Berlin Sans FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(628, 34);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(74, 30);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "label1";
            // 
            // FrmMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMDI";
            Text = "CineFlix";
            WindowState = FormWindowState.Maximized;
            Load += FrmMDI_Load;
            Resize += FrmMDI_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem peliculasToolStripMenuItem;
        private ToolStripMenuItem misPeliculasToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
        private Label lblUsuario;
    }
}