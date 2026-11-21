namespace FitCR.Vista
{
    partial class RutinasView
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
            GrdRutinas = new DataGridView();
            LblNombre = new Label();
            TxtNombre = new TextBox();
            LblUsuario = new Label();
            CboUsuario = new ComboBox();
            LblVigencia = new Label();
            DtpVigencia = new DateTimePicker();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdRutinas).BeginInit();
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
            LblTitulo.Text = "Rutinas";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GrdRutinas
            // 
            GrdRutinas.AllowUserToAddRows = false;
            GrdRutinas.AllowUserToDeleteRows = false;
            GrdRutinas.ReadOnly = true;
            GrdRutinas.RowHeadersWidth = 51;
            GrdRutinas.Location = new Point(60, 90);
            GrdRutinas.Name = "GrdRutinas";
            GrdRutinas.Size = new Size(880, 290);
            GrdRutinas.TabIndex = 1;
            GrdRutinas.SelectionChanged += GrdRutinas_SelectionChanged;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.ForeColor = Color.White;
            LblNombre.Location = new Point(60, 410);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(79, 24);
            LblNombre.TabIndex = 2;
            LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(170, 406);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(260, 27);
            TxtNombre.TabIndex = 3;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.White;
            LblUsuario.Location = new Point(470, 410);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(81, 24);
            LblUsuario.TabIndex = 4;
            LblUsuario.Text = "Usuario:";
            // 
            // CboUsuario
            // 
            CboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            CboUsuario.FormattingEnabled = true;
            CboUsuario.Location = new Point(560, 406);
            CboUsuario.Name = "CboUsuario";
            CboUsuario.Size = new Size(260, 28);
            CboUsuario.TabIndex = 5;
            // 
            // LblVigencia
            // 
            LblVigencia.AutoSize = true;
            LblVigencia.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblVigencia.ForeColor = Color.White;
            LblVigencia.Location = new Point(60, 465);
            LblVigencia.Name = "LblVigencia";
            LblVigencia.Size = new Size(124, 24);
            LblVigencia.TabIndex = 6;
            LblVigencia.Text = "Vigencia hasta:";
            // 
            // DtpVigencia
            // 
            DtpVigencia.Format = DateTimePickerFormat.Short;
            DtpVigencia.Location = new Point(230, 461);
            DtpVigencia.Name = "DtpVigencia";
            DtpVigencia.Size = new Size(160, 27);
            DtpVigencia.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Lime;
            BtnAgregar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.Location = new Point(60, 540);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(200, 45);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Lime;
            BtnEditar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.Location = new Point(280, 540);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(200, 45);
            BtnEditar.TabIndex = 9;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Lime;
            BtnEliminar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(500, 540);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(200, 45);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(740, 540);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(200, 45);
            BtnVolver.TabIndex = 11;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // RutinasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 640);
            Controls.Add(BtnVolver);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(DtpVigencia);
            Controls.Add(LblVigencia);
            Controls.Add(CboUsuario);
            Controls.Add(LblUsuario);
            Controls.Add(TxtNombre);
            Controls.Add(LblNombre);
            Controls.Add(GrdRutinas);
            Controls.Add(LblTitulo);
            Name = "RutinasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rutinas";
            ((System.ComponentModel.ISupportInitialize)GrdRutinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private DataGridView GrdRutinas;
        private Label LblNombre;
        private TextBox TxtNombre;
        private Label LblUsuario;
        private ComboBox CboUsuario;
        private Label LblVigencia;
        private DateTimePicker DtpVigencia;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnVolver;
    }
}