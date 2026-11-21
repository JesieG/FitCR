namespace FitCR.Vista
{
    partial class EstadisticasView
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
            LblDesde = new Label();
            LblHasta = new Label();
            DtpDesde = new DateTimePicker();
            DtpHasta = new DateTimePicker();
            BtnGenerar = new Button();
            LblTopVisitantes = new Label();
            LblTopAusentes = new Label();
            GrdTopVisitantes = new DataGridView();
            GrdTopAusentes = new DataGridView();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdTopVisitantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrdTopAusentes).BeginInit();
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
            LblTitulo.Text = "Estadisticas";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDesde
            // 
            LblDesde.AutoSize = true;
            LblDesde.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDesde.ForeColor = Color.White;
            LblDesde.Location = new Point(210, 100);
            LblDesde.Name = "LblDesde";
            LblDesde.Size = new Size(68, 24);
            LblDesde.TabIndex = 1;
            LblDesde.Text = "Desde:";
            // 
            // LblHasta
            // 
            LblHasta.AutoSize = true;
            LblHasta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblHasta.ForeColor = Color.White;
            LblHasta.Location = new Point(480, 100);
            LblHasta.Name = "LblHasta";
            LblHasta.Size = new Size(64, 24);
            LblHasta.TabIndex = 2;
            LblHasta.Text = "Hasta:";
            // 
            // DtpDesde
            // 
            DtpDesde.Format = DateTimePickerFormat.Short;
            DtpDesde.Location = new Point(285, 96);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(160, 27);
            DtpDesde.TabIndex = 3;
            // 
            // DtpHasta
            // 
            DtpHasta.Format = DateTimePickerFormat.Short;
            DtpHasta.Location = new Point(555, 96);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(160, 27);
            DtpHasta.TabIndex = 4;
            // 
            // BtnGenerar
            // 
            BtnGenerar.BackColor = Color.Lime;
            BtnGenerar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGenerar.Location = new Point(752, 89);
            BtnGenerar.Name = "BtnGenerar";
            BtnGenerar.Size = new Size(140, 40);
            BtnGenerar.TabIndex = 5;
            BtnGenerar.Text = "Generar";
            BtnGenerar.UseVisualStyleBackColor = false;
            BtnGenerar.Click += BtnGenerar_Click;
            // 
            // LblTopVisitantes
            // 
            LblTopVisitantes.AutoSize = true;
            LblTopVisitantes.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTopVisitantes.ForeColor = Color.Lime;
            LblTopVisitantes.Location = new Point(80, 160);
            LblTopVisitantes.Name = "LblTopVisitantes";
            LblTopVisitantes.Size = new Size(176, 24);
            LblTopVisitantes.TabIndex = 6;
            LblTopVisitantes.Text = "Top 10 de visitantes";
            // 
            // LblTopAusentes
            // 
            LblTopAusentes.AutoSize = true;
            LblTopAusentes.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTopAusentes.ForeColor = Color.Lime;
            LblTopAusentes.Location = new Point(530, 160);
            LblTopAusentes.Name = "LblTopAusentes";
            LblTopAusentes.Size = new Size(171, 24);
            LblTopAusentes.TabIndex = 7;
            LblTopAusentes.Text = "Top 10 de ausentes";
            // 
            // GrdTopVisitantes
            // 
            GrdTopVisitantes.AllowUserToAddRows = false;
            GrdTopVisitantes.AllowUserToDeleteRows = false;
            GrdTopVisitantes.ColumnHeadersHeight = 29;
            GrdTopVisitantes.Location = new Point(80, 195);
            GrdTopVisitantes.Name = "GrdTopVisitantes";
            GrdTopVisitantes.ReadOnly = true;
            GrdTopVisitantes.RowHeadersWidth = 51;
            GrdTopVisitantes.Size = new Size(390, 340);
            GrdTopVisitantes.TabIndex = 8;
            // 
            // GrdTopAusentes
            // 
            GrdTopAusentes.AllowUserToAddRows = false;
            GrdTopAusentes.AllowUserToDeleteRows = false;
            GrdTopAusentes.ColumnHeadersHeight = 29;
            GrdTopAusentes.Location = new Point(530, 195);
            GrdTopAusentes.Name = "GrdTopAusentes";
            GrdTopAusentes.ReadOnly = true;
            GrdTopAusentes.RowHeadersWidth = 51;
            GrdTopAusentes.Size = new Size(390, 340);
            GrdTopAusentes.TabIndex = 9;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(365, 580);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(270, 45);
            BtnVolver.TabIndex = 10;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // EstadisticasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 660);
            Controls.Add(BtnVolver);
            Controls.Add(GrdTopAusentes);
            Controls.Add(GrdTopVisitantes);
            Controls.Add(LblTopAusentes);
            Controls.Add(LblTopVisitantes);
            Controls.Add(BtnGenerar);
            Controls.Add(DtpHasta);
            Controls.Add(DtpDesde);
            Controls.Add(LblHasta);
            Controls.Add(LblDesde);
            Controls.Add(LblTitulo);
            Name = "EstadisticasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)GrdTopVisitantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrdTopAusentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label LblDesde;
        private Label LblHasta;
        private DateTimePicker DtpDesde;
        private DateTimePicker DtpHasta;
        private Button BtnGenerar;
        private Label LblTopVisitantes;
        private Label LblTopAusentes;
        private DataGridView GrdTopVisitantes;
        private DataGridView GrdTopAusentes;
        private Button BtnVolver;
    }
}