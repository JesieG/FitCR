namespace FitCR.Vista
{
    partial class MenuUsuarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuarioView));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LblBienvenida = new Label();
            BtnPerfil = new Button();
            BtnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(604, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // LblBienvenida
            // 
            LblBienvenida.AutoSize = true;
            LblBienvenida.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBienvenida.ForeColor = Color.White;
            LblBienvenida.Location = new Point(604, 167);
            LblBienvenida.Name = "LblBienvenida";
            LblBienvenida.Size = new Size(89, 37);
            LblBienvenida.TabIndex = 2;
            LblBienvenida.Text = "Hola, ";
            LblBienvenida.Click += label2_Click;
            // 
            // BtnPerfil
            // 
            BtnPerfil.BackColor = Color.Lime;
            BtnPerfil.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPerfil.Location = new Point(483, 276);
            BtnPerfil.Margin = new Padding(4, 5, 4, 5);
            BtnPerfil.Name = "BtnPerfil";
            BtnPerfil.Size = new Size(423, 54);
            BtnPerfil.TabIndex = 15;
            BtnPerfil.Text = "Mi perfil";
            BtnPerfil.UseVisualStyleBackColor = false;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.BackColor = Color.Lime;
            BtnCerrarSesion.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarSesion.Location = new Point(483, 392);
            BtnCerrarSesion.Margin = new Padding(4, 5, 4, 5);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(423, 54);
            BtnCerrarSesion.TabIndex = 16;
            BtnCerrarSesion.Text = "Cerrar Sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // MenuUsuarioView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1388, 741);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(BtnPerfil);
            Controls.Add(LblBienvenida);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MenuUsuarioView";
            Text = "MenuUsuarioView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label LblBienvenida;
        private Button BtnPerfil;
        private Button BtnCerrarSesion;
    }
}