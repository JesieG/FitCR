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
            LblBienvenida = new Label();
            BtnPerfil = new Button();
            BtnHistorial = new Button();
            BtnEstadisticas = new Button();
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
            BtnPerfil.Click += BtnPerfil_Click;
            // 
            // BtnHistorial
            // 
            BtnHistorial.BackColor = Color.Lime;
            BtnHistorial.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHistorial.Location = new Point(483, 353);
            BtnHistorial.Margin = new Padding(4, 5, 4, 5);
            BtnHistorial.Name = "BtnHistorial";
            BtnHistorial.Size = new Size(423, 54);
            BtnHistorial.TabIndex = 17;
            BtnHistorial.Text = "Historial";
            BtnHistorial.UseVisualStyleBackColor = false;
            BtnHistorial.Click += BtnHistorial_Click;
            // 
            // BtnEstadisticas
            // 
            BtnEstadisticas.BackColor = Color.Lime;
            BtnEstadisticas.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEstadisticas.Location = new Point(483, 431);
            BtnEstadisticas.Margin = new Padding(4, 5, 4, 5);
            BtnEstadisticas.Name = "BtnEstadisticas";
            BtnEstadisticas.Size = new Size(423, 54);
            BtnEstadisticas.TabIndex = 18;
            BtnEstadisticas.Text = "Estadisticas";
            BtnEstadisticas.UseVisualStyleBackColor = false;
            BtnEstadisticas.Click += BtnEstadisticas_Click;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.BackColor = Color.Lime;
            BtnCerrarSesion.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarSesion.Location = new Point(483, 509);
            BtnCerrarSesion.Margin = new Padding(4, 5, 4, 5);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(423, 54);
            BtnCerrarSesion.TabIndex = 16;
            BtnCerrarSesion.Text = "Cerrar Sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // MenuUsuarioView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1388, 741);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(BtnEstadisticas);
            Controls.Add(BtnHistorial);
            Controls.Add(BtnPerfil);
            Controls.Add(LblBienvenida);
            Controls.Add(pictureBox1);
            Name = "MenuUsuarioView";
            Text = "MenuUsuarioView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblBienvenida;
        private Button BtnPerfil;
        private Button BtnHistorial;
        private Button BtnEstadisticas;
        private Button BtnCerrarSesion;
    }
}