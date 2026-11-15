namespace FitCR.Vista
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            label1 = new Label();
            label2 = new Label();
            TxtContrasena = new TextBox();
            TxtUsuario = new TextBox();
            BtnIngresar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            BtnRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(567, 265);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(565, 385);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // TxtContrasena
            // 
            TxtContrasena.Location = new Point(566, 419);
            TxtContrasena.Margin = new Padding(4);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.PasswordChar = '*';
            TxtContrasena.Size = new Size(265, 32);
            TxtContrasena.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(566, 301);
            TxtUsuario.Margin = new Padding(4);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(265, 32);
            TxtUsuario.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.Lime;
            BtnIngresar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold);
            BtnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            BtnIngresar.Location = new Point(561, 518);
            BtnIngresar.Margin = new Padding(4);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(270, 40);
            BtnIngresar.TabIndex = 4;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(648, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 53);
            label3.TabIndex = 5;
            label3.Text = "Fit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(696, 120);
            label4.Name = "label4";
            label4.Size = new Size(80, 53);
            label4.TabIndex = 6;
            label4.Text = ".CR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code ExtraLight", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(626, 172);
            label5.Name = "label5";
            label5.Size = new Size(207, 27);
            label5.TabIndex = 7;
            label5.Text = "Gestión Fitness";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(655, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BtnRegistro
            // 
            BtnRegistro.BackColor = Color.Lime;
            BtnRegistro.Font = new Font("Lucida Bright", 12F, FontStyle.Bold);
            BtnRegistro.ForeColor = SystemColors.ActiveCaptionText;
            BtnRegistro.Location = new Point(561, 590);
            BtnRegistro.Margin = new Padding(4);
            BtnRegistro.Name = "BtnRegistro";
            BtnRegistro.Size = new Size(270, 40);
            BtnRegistro.TabIndex = 9;
            BtnRegistro.Text = "Crear Cuenta";
            BtnRegistro.UseVisualStyleBackColor = false;
            BtnRegistro.Click += BtnRegistro_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1395, 727);
            Controls.Add(BtnRegistro);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnIngresar);
            Controls.Add(TxtUsuario);
            Controls.Add(TxtContrasena);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginView";
            Text = "FIT.CR";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegistro;
    }
}