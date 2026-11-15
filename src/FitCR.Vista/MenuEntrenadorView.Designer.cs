namespace FitCR.Vista
{
    partial class MenuEntrenadorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEntrenadorView));
            pictureBox1 = new PictureBox();
            LblBienvenida = new Label();
            LblTipo = new Label();
            BtnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(593, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LblBienvenida
            // 
            LblBienvenida.AutoSize = true;
            LblBienvenida.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBienvenida.ForeColor = Color.White;
            LblBienvenida.Location = new Point(545, 206);
            LblBienvenida.Name = "LblBienvenida";
            LblBienvenida.Size = new Size(89, 37);
            LblBienvenida.TabIndex = 10;
            LblBienvenida.Text = "Hola, ";
            // 
            // LblTipo
            // 
            LblTipo.AutoSize = true;
            LblTipo.Font = new Font("Calibri Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTipo.ForeColor = Color.White;
            LblTipo.Location = new Point(468, 335);
            LblTipo.Name = "LblTipo";
            LblTipo.Size = new Size(196, 28);
            LblTipo.TabIndex = 11;
            LblTipo.Text = "Tipo de entrenador:";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.BackColor = Color.Lime;
            BtnCerrarSesion.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarSesion.Location = new Point(468, 492);
            BtnCerrarSesion.Margin = new Padding(4, 5, 4, 5);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(423, 54);
            BtnCerrarSesion.TabIndex = 16;
            BtnCerrarSesion.Text = "Cerrar Sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // MenuEntrenadorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1356, 750);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(LblTipo);
            Controls.Add(LblBienvenida);
            Controls.Add(pictureBox1);
            Name = "MenuEntrenadorView";
            Text = "MenuEntrenadorView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblBienvenida;
        private Label LblTipo;
        private Button BtnCerrarSesion;
    }
}