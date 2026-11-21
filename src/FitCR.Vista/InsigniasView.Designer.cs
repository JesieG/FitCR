namespace FitCR.Vista
{
    partial class InsigniasView
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
            LblLogros = new Label();
            LblVerguenza = new Label();
            GrdLogros = new DataGridView();
            GrdVerguenza = new DataGridView();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdLogros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrdVerguenza).BeginInit();
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
            LblTitulo.Text = "Mis insignias";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLogros
            // 
            LblLogros.AutoSize = true;
            LblLogros.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLogros.ForeColor = Color.Lime;
            LblLogros.Location = new Point(60, 95);
            LblLogros.Name = "LblLogros";
            LblLogros.Size = new Size(156, 24);
            LblLogros.TabIndex = 1;
            LblLogros.Text = "Insignias de logro";
            // 
            // LblVerguenza
            // 
            LblVerguenza.AutoSize = true;
            LblVerguenza.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblVerguenza.ForeColor = Color.OrangeRed;
            LblVerguenza.Location = new Point(520, 95);
            LblVerguenza.Name = "LblVerguenza";
            LblVerguenza.Size = new Size(212, 24);
            LblVerguenza.TabIndex = 2;
            LblVerguenza.Text = "Insignias de la vergüenza";
            // 
            // GrdLogros
            // 
            GrdLogros.AllowUserToAddRows = false;
            GrdLogros.AllowUserToDeleteRows = false;
            GrdLogros.ReadOnly = true;
            GrdLogros.RowHeadersWidth = 51;
            GrdLogros.Location = new Point(60, 130);
            GrdLogros.Name = "GrdLogros";
            GrdLogros.Size = new Size(420, 380);
            GrdLogros.TabIndex = 3;
            // 
            // GrdVerguenza
            // 
            GrdVerguenza.AllowUserToAddRows = false;
            GrdVerguenza.AllowUserToDeleteRows = false;
            GrdVerguenza.ReadOnly = true;
            GrdVerguenza.RowHeadersWidth = 51;
            GrdVerguenza.Location = new Point(520, 130);
            GrdVerguenza.Name = "GrdVerguenza";
            GrdVerguenza.Size = new Size(420, 380);
            GrdVerguenza.TabIndex = 4;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(365, 545);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(270, 45);
            BtnVolver.TabIndex = 5;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // InsigniasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 620);
            Controls.Add(BtnVolver);
            Controls.Add(GrdVerguenza);
            Controls.Add(GrdLogros);
            Controls.Add(LblVerguenza);
            Controls.Add(LblLogros);
            Controls.Add(LblTitulo);
            Name = "InsigniasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insignias";
            ((System.ComponentModel.ISupportInitialize)GrdLogros).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrdVerguenza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label LblLogros;
        private Label LblVerguenza;
        private DataGridView GrdLogros;
        private DataGridView GrdVerguenza;
        private Button BtnVolver;
    }
}