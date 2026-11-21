namespace FitCR.Vista
{
    partial class NotificacionesView
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
            LblResumen = new Label();
            GrdNotificaciones = new DataGridView();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdNotificaciones).BeginInit();
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
            LblTitulo.Text = "Notificaciones";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblResumen
            // 
            LblResumen.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblResumen.ForeColor = Color.Lime;
            LblResumen.Location = new Point(0, 75);
            LblResumen.Name = "LblResumen";
            LblResumen.Size = new Size(1000, 30);
            LblResumen.TabIndex = 1;
            LblResumen.Text = "Total de notificaciones: 0";
            LblResumen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GrdNotificaciones
            // 
            GrdNotificaciones.AllowUserToAddRows = false;
            GrdNotificaciones.AllowUserToDeleteRows = false;
            GrdNotificaciones.ReadOnly = true;
            GrdNotificaciones.RowHeadersWidth = 51;
            GrdNotificaciones.Location = new Point(60, 120);
            GrdNotificaciones.Name = "GrdNotificaciones";
            GrdNotificaciones.Size = new Size(880, 390);
            GrdNotificaciones.TabIndex = 2;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(365, 545);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(270, 45);
            BtnVolver.TabIndex = 3;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // NotificacionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 620);
            Controls.Add(BtnVolver);
            Controls.Add(GrdNotificaciones);
            Controls.Add(LblResumen);
            Controls.Add(LblTitulo);
            Name = "NotificacionesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notificaciones";
            ((System.ComponentModel.ISupportInitialize)GrdNotificaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LblTitulo;
        private Label LblResumen;
        private DataGridView GrdNotificaciones;
        private Button BtnVolver;
    }
}