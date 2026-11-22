namespace FitCR.Vista
{
    partial class VisitasView
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
            LblTitulo = new Label();
            LblUsuario = new Label();
            CboUsuario = new ComboBox();
            GrdVisitas = new DataGridView();
            BtnRegistrar = new Button();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdVisitas).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(0, 20);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(1000, 50);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Visitas";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.White;
            LblUsuario.Location = new Point(60, 95);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(81, 24);
            LblUsuario.TabIndex = 1;
            LblUsuario.Text = "Usuario:";
            // 
            // CboUsuario
            // 
            CboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            CboUsuario.FormattingEnabled = true;
            CboUsuario.Location = new Point(150, 91);
            CboUsuario.Name = "CboUsuario";
            CboUsuario.Size = new Size(300, 28);
            CboUsuario.TabIndex = 2;
            CboUsuario.SelectedIndexChanged += CboUsuario_SelectedIndexChanged;
            // 
            // GrdVisitas
            // 
            GrdVisitas.AllowUserToAddRows = false;
            GrdVisitas.AllowUserToDeleteRows = false;
            GrdVisitas.ReadOnly = true;
            GrdVisitas.RowHeadersWidth = 51;
            GrdVisitas.Location = new Point(60, 140);
            GrdVisitas.Name = "GrdVisitas";
            GrdVisitas.Size = new Size(880, 330);
            GrdVisitas.TabIndex = 3;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.Lime;
            BtnRegistrar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.Location = new Point(60, 500);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(320, 45);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "Registrar visita de hoy";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(740, 500);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(200, 45);
            BtnVolver.TabIndex = 5;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // VisitasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 580);
            Controls.Add(BtnVolver);
            Controls.Add(BtnRegistrar);
            Controls.Add(GrdVisitas);
            Controls.Add(CboUsuario);
            Controls.Add(LblUsuario);
            Controls.Add(LblTitulo);
            Name = "VisitasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visitas";
            ((System.ComponentModel.ISupportInitialize)GrdVisitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label LblUsuario;
        private ComboBox CboUsuario;
        private DataGridView GrdVisitas;
        private Button BtnRegistrar;
        private Button BtnVolver;
    }
}