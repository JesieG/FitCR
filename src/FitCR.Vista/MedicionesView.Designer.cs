namespace FitCR.Vista
{
    partial class MedicionesView
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
            GrdMediciones = new DataGridView();
            LblFecha = new Label();
            DtpFecha = new DateTimePicker();
            LblPeso = new Label();
            TxtPeso = new TextBox();
            LblGrasa = new Label();
            TxtGrasa = new TextBox();
            LblMusculatura = new Label();
            TxtMusculatura = new TextBox();
            BtnRegistrar = new Button();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdMediciones).BeginInit();
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
            LblTitulo.Text = "Mediciones";
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
            // GrdMediciones
            // 
            GrdMediciones.AllowUserToAddRows = false;
            GrdMediciones.AllowUserToDeleteRows = false;
            GrdMediciones.ReadOnly = true;
            GrdMediciones.RowHeadersWidth = 51;
            GrdMediciones.Location = new Point(60, 140);
            GrdMediciones.Name = "GrdMediciones";
            GrdMediciones.Size = new Size(880, 240);
            GrdMediciones.TabIndex = 3;
            // 
            // LblFecha
            // 
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFecha.ForeColor = Color.White;
            LblFecha.Location = new Point(60, 415);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(63, 24);
            LblFecha.TabIndex = 4;
            LblFecha.Text = "Fecha:";
            // 
            // DtpFecha
            // 
            DtpFecha.Format = DateTimePickerFormat.Short;
            DtpFecha.Location = new Point(140, 411);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(160, 27);
            DtpFecha.TabIndex = 5;
            // 
            // LblPeso
            // 
            LblPeso.AutoSize = true;
            LblPeso.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPeso.ForeColor = Color.White;
            LblPeso.Location = new Point(340, 415);
            LblPeso.Name = "LblPeso";
            LblPeso.Size = new Size(93, 24);
            LblPeso.TabIndex = 6;
            LblPeso.Text = "Peso (kg):";
            // 
            // TxtPeso
            // 
            TxtPeso.Location = new Point(450, 411);
            TxtPeso.Name = "TxtPeso";
            TxtPeso.Size = new Size(100, 27);
            TxtPeso.TabIndex = 7;
            // 
            // LblGrasa
            // 
            LblGrasa.AutoSize = true;
            LblGrasa.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblGrasa.ForeColor = Color.White;
            LblGrasa.Location = new Point(60, 470);
            LblGrasa.Name = "LblGrasa";
            LblGrasa.Size = new Size(98, 24);
            LblGrasa.TabIndex = 8;
            LblGrasa.Text = "Grasa (%):";
            // 
            // TxtGrasa
            // 
            TxtGrasa.Location = new Point(170, 466);
            TxtGrasa.Name = "TxtGrasa";
            TxtGrasa.Size = new Size(100, 27);
            TxtGrasa.TabIndex = 9;
            // 
            // LblMusculatura
            // 
            LblMusculatura.AutoSize = true;
            LblMusculatura.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMusculatura.ForeColor = Color.White;
            LblMusculatura.Location = new Point(340, 470);
            LblMusculatura.Name = "LblMusculatura";
            LblMusculatura.Size = new Size(147, 24);
            LblMusculatura.TabIndex = 10;
            LblMusculatura.Text = "Musculatura (%):";
            // 
            // TxtMusculatura
            // 
            TxtMusculatura.Location = new Point(500, 466);
            TxtMusculatura.Name = "TxtMusculatura";
            TxtMusculatura.Size = new Size(100, 27);
            TxtMusculatura.TabIndex = 11;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.Lime;
            BtnRegistrar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.Location = new Point(60, 550);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(200, 45);
            BtnRegistrar.TabIndex = 12;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(740, 550);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(200, 45);
            BtnVolver.TabIndex = 13;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // MedicionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 640);
            Controls.Add(BtnVolver);
            Controls.Add(BtnRegistrar);
            Controls.Add(TxtMusculatura);
            Controls.Add(LblMusculatura);
            Controls.Add(TxtGrasa);
            Controls.Add(LblGrasa);
            Controls.Add(TxtPeso);
            Controls.Add(LblPeso);
            Controls.Add(DtpFecha);
            Controls.Add(LblFecha);
            Controls.Add(GrdMediciones);
            Controls.Add(CboUsuario);
            Controls.Add(LblUsuario);
            Controls.Add(LblTitulo);
            Name = "MedicionesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mediciones";
            ((System.ComponentModel.ISupportInitialize)GrdMediciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label LblUsuario;
        private ComboBox CboUsuario;
        private DataGridView GrdMediciones;
        private Label LblFecha;
        private DateTimePicker DtpFecha;
        private Label LblPeso;
        private TextBox TxtPeso;
        private Label LblGrasa;
        private TextBox TxtGrasa;
        private Label LblMusculatura;
        private TextBox TxtMusculatura;
        private Button BtnRegistrar;
        private Button BtnVolver;
    }
}