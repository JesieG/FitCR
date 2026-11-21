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
            TabEstadisticas = new TabControl();
            tabPage1 = new TabPage();
            LblTopVisitantes = new Label();
            LblTopAusentes = new Label();
            GrdTopVisitantes = new DataGridView();
            GrdTopAusentes = new DataGridView();
            tabPage2 = new TabPage();
            GrdAumentos = new DataGridView();
            tabPage3 = new TabPage();
            GrdObjetivos = new DataGridView();
            BtnVolver = new Button();
            TabEstadisticas.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdTopVisitantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrdTopAusentes).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdAumentos).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdObjetivos).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(0, 15);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(1000, 45);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Estadisticas";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDesde
            // 
            LblDesde.AutoSize = true;
            LblDesde.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDesde.ForeColor = Color.White;
            LblDesde.Location = new Point(210, 80);
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
            LblHasta.Location = new Point(480, 80);
            LblHasta.Name = "LblHasta";
            LblHasta.Size = new Size(65, 24);
            LblHasta.TabIndex = 2;
            LblHasta.Text = "Hasta:";
            // 
            // DtpDesde
            // 
            DtpDesde.Format = DateTimePickerFormat.Short;
            DtpDesde.Location = new Point(285, 76);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(160, 27);
            DtpDesde.TabIndex = 3;
            // 
            // DtpHasta
            // 
            DtpHasta.Format = DateTimePickerFormat.Short;
            DtpHasta.Location = new Point(555, 76);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(160, 27);
            DtpHasta.TabIndex = 4;
            // 
            // BtnGenerar
            // 
            BtnGenerar.BackColor = Color.Lime;
            BtnGenerar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGenerar.Location = new Point(745, 68);
            BtnGenerar.Name = "BtnGenerar";
            BtnGenerar.Size = new Size(140, 40);
            BtnGenerar.TabIndex = 5;
            BtnGenerar.Text = "Generar";
            BtnGenerar.UseVisualStyleBackColor = false;
            BtnGenerar.Click += BtnGenerar_Click;
            // 
            // TabEstadisticas
            // 
            TabEstadisticas.Controls.Add(tabPage1);
            TabEstadisticas.Controls.Add(tabPage2);
            TabEstadisticas.Controls.Add(tabPage3);
            TabEstadisticas.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabEstadisticas.Location = new Point(60, 130);
            TabEstadisticas.Name = "TabEstadisticas";
            TabEstadisticas.SelectedIndex = 0;
            TabEstadisticas.Size = new Size(880, 450);
            TabEstadisticas.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(LblTopVisitantes);
            tabPage1.Controls.Add(LblTopAusentes);
            tabPage1.Controls.Add(GrdTopVisitantes);
            tabPage1.Controls.Add(GrdTopAusentes);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(872, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Visitantes y ausentes";
            // 
            // LblTopVisitantes
            // 
            LblTopVisitantes.AutoSize = true;
            LblTopVisitantes.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTopVisitantes.ForeColor = Color.Lime;
            LblTopVisitantes.Location = new Point(20, 12);
            LblTopVisitantes.Name = "LblTopVisitantes";
            LblTopVisitantes.Size = new Size(176, 24);
            LblTopVisitantes.TabIndex = 0;
            LblTopVisitantes.Text = "Top 10 de visitantes";
            // 
            // LblTopAusentes
            // 
            LblTopAusentes.AutoSize = true;
            LblTopAusentes.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTopAusentes.ForeColor = Color.Lime;
            LblTopAusentes.Location = new Point(450, 12);
            LblTopAusentes.Name = "LblTopAusentes";
            LblTopAusentes.Size = new Size(166, 24);
            LblTopAusentes.TabIndex = 1;
            LblTopAusentes.Text = "Top 10 de ausentes";
            // 
            // GrdTopVisitantes
            // 
            GrdTopVisitantes.AllowUserToAddRows = false;
            GrdTopVisitantes.AllowUserToDeleteRows = false;
            GrdTopVisitantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdTopVisitantes.Location = new Point(20, 45);
            GrdTopVisitantes.Name = "GrdTopVisitantes";
            GrdTopVisitantes.ReadOnly = true;
            GrdTopVisitantes.RowHeadersWidth = 51;
            GrdTopVisitantes.Size = new Size(410, 350);
            GrdTopVisitantes.TabIndex = 2;
            // 
            // GrdTopAusentes
            // 
            GrdTopAusentes.AllowUserToAddRows = false;
            GrdTopAusentes.AllowUserToDeleteRows = false;
            GrdTopAusentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdTopAusentes.Location = new Point(450, 45);
            GrdTopAusentes.Name = "GrdTopAusentes";
            GrdTopAusentes.ReadOnly = true;
            GrdTopAusentes.RowHeadersWidth = 51;
            GrdTopAusentes.Size = new Size(410, 350);
            GrdTopAusentes.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GrdAumentos);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(872, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Aumento de pesos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrdAumentos
            // 
            GrdAumentos.AllowUserToAddRows = false;
            GrdAumentos.AllowUserToDeleteRows = false;
            GrdAumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdAumentos.Dock = DockStyle.Fill;
            GrdAumentos.Location = new Point(0, 0);
            GrdAumentos.Name = "GrdAumentos";
            GrdAumentos.ReadOnly = true;
            GrdAumentos.RowHeadersWidth = 51;
            GrdAumentos.Size = new Size(872, 413);
            GrdAumentos.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(GrdObjetivos);
            tabPage3.Location = new Point(4, 33);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(872, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mejoras en objetivos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // GrdObjetivos
            // 
            GrdObjetivos.AllowUserToAddRows = false;
            GrdObjetivos.AllowUserToDeleteRows = false;
            GrdObjetivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdObjetivos.Dock = DockStyle.Fill;
            GrdObjetivos.Location = new Point(0, 0);
            GrdObjetivos.Name = "GrdObjetivos";
            GrdObjetivos.ReadOnly = true;
            GrdObjetivos.RowHeadersWidth = 51;
            GrdObjetivos.Size = new Size(872, 413);
            GrdObjetivos.TabIndex = 0;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(365, 605);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(270, 45);
            BtnVolver.TabIndex = 7;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // EstadisticasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 670);
            Controls.Add(BtnVolver);
            Controls.Add(TabEstadisticas);
            Controls.Add(BtnGenerar);
            Controls.Add(DtpHasta);
            Controls.Add(DtpDesde);
            Controls.Add(LblHasta);
            Controls.Add(LblDesde);
            Controls.Add(LblTitulo);
            Name = "EstadisticasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas";
            TabEstadisticas.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GrdTopVisitantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrdTopAusentes).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdAumentos).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdObjetivos).EndInit();
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
        private TabControl TabEstadisticas;
        private TabPage tabPage1;
        private Label LblTopVisitantes;
        private Label LblTopAusentes;
        private DataGridView GrdTopVisitantes;
        private DataGridView GrdTopAusentes;
        private TabPage tabPage2;
        private DataGridView GrdAumentos;
        private TabPage tabPage3;
        private DataGridView GrdObjetivos;
        private Button BtnVolver;
    }
}