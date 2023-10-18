namespace Formulario
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(192, 0, 0);
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(38, 223);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(312, 45);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(275, 351);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 39);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 2;
            label1.Text = "Inicia sesión";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Silver;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = SystemColors.ControlText;
            txtCorreo.Location = new Point(38, 96);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo electrónico";
            txtCorreo.Size = new Size(312, 29);
            txtCorreo.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Silver;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(38, 155);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(312, 29);
            txtClave.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.inicio_cineflix;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(389, 399);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "Form1";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtClave;
    }
}