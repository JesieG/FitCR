namespace FitCR.Vista
{
    partial class ClasesView
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
            GrdClases = new DataGridView();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdClases).BeginInit();
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
            LblTitulo.Text = "Clases del gimnasio";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GrdClases
            // 
            GrdClases.AllowUserToAddRows = false;
            GrdClases.AllowUserToDeleteRows = false;
            GrdClases.ReadOnly = true;
            GrdClases.RowHeadersWidth = 51;
            GrdClases.Location = new Point(60, 90);
            GrdClases.Name = "GrdClases";
            GrdClases.Size = new Size(880, 420);
            GrdClases.TabIndex = 1;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(365, 545);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(270, 45);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // ClasesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 620);
            Controls.Add(BtnVolver);
            Controls.Add(GrdClases);
            Controls.Add(LblTitulo);
            Name = "ClasesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clases";
            ((System.ComponentModel.ISupportInitialize)GrdClases).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LblTitulo;
        private DataGridView GrdClases;
        private Button BtnVolver;
    }
}