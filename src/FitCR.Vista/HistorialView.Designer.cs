namespace FitCR.Vista
{
    partial class HistorialView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialView));
            TabHistorial = new TabControl();
            tabPage1 = new TabPage();
            GrdVisitas = new DataGridView();
            tabPage2 = new TabPage();
            GrdRutinas = new DataGridView();
            tabPage3 = new TabPage();
            GrdMediciones = new DataGridView();
            tabPage4 = new TabPage();
            GrdAumentos = new DataGridView();
            BtnVolver = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TabHistorial.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdVisitas).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdRutinas).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdMediciones).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdAumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TabHistorial
            // 
            TabHistorial.AccessibleRole = AccessibleRole.None;
            TabHistorial.Controls.Add(tabPage1);
            TabHistorial.Controls.Add(tabPage2);
            TabHistorial.Controls.Add(tabPage3);
            TabHistorial.Controls.Add(tabPage4);
            TabHistorial.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabHistorial.Location = new Point(415, 144);
            TabHistorial.Name = "TabHistorial";
            TabHistorial.SelectedIndex = 0;
            TabHistorial.Size = new Size(560, 319);
            TabHistorial.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(GrdVisitas);
            tabPage1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 282);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Visitas";
            // 
            // GrdVisitas
            // 
            GrdVisitas.AllowUserToAddRows = false;
            GrdVisitas.BackgroundColor = Color.Silver;
            GrdVisitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdVisitas.Dock = DockStyle.Fill;
            GrdVisitas.GridColor = SystemColors.HighlightText;
            GrdVisitas.Location = new Point(3, 3);
            GrdVisitas.Name = "GrdVisitas";
            GrdVisitas.ReadOnly = true;
            GrdVisitas.RowHeadersWidth = 51;
            GrdVisitas.Size = new Size(542, 272);
            GrdVisitas.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GrdRutinas);
            tabPage2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(552, 282);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ultimas rutinas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrdRutinas
            // 
            GrdRutinas.AllowUserToAddRows = false;
            GrdRutinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdRutinas.Dock = DockStyle.Fill;
            GrdRutinas.Location = new Point(3, 3);
            GrdRutinas.Name = "GrdRutinas";
            GrdRutinas.ReadOnly = true;
            GrdRutinas.RowHeadersWidth = 51;
            GrdRutinas.Size = new Size(546, 276);
            GrdRutinas.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(GrdMediciones);
            tabPage3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 33);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(552, 282);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mediciones";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // GrdMediciones
            // 
            GrdMediciones.AllowUserToAddRows = false;
            GrdMediciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdMediciones.Dock = DockStyle.Fill;
            GrdMediciones.Location = new Point(0, 0);
            GrdMediciones.Name = "GrdMediciones";
            GrdMediciones.ReadOnly = true;
            GrdMediciones.RowHeadersWidth = 51;
            GrdMediciones.Size = new Size(552, 282);
            GrdMediciones.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(GrdAumentos);
            tabPage4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage4.Location = new Point(4, 33);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(552, 282);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Control de aumentos";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // GrdAumentos
            // 
            GrdAumentos.AllowUserToAddRows = false;
            GrdAumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdAumentos.Dock = DockStyle.Fill;
            GrdAumentos.Location = new Point(0, 0);
            GrdAumentos.Name = "GrdAumentos";
            GrdAumentos.ReadOnly = true;
            GrdAumentos.RowHeadersWidth = 51;
            GrdAumentos.Size = new Size(552, 282);
            GrdAumentos.TabIndex = 0;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Lime;
            BtnVolver.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(462, 499);
            BtnVolver.Margin = new Padding(4, 5, 4, 5);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(423, 54);
            BtnVolver.TabIndex = 16;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(639, 72);
            label1.Name = "label1";
            label1.Size = new Size(198, 45);
            label1.TabIndex = 18;
            label1.Text = "Mi Historial";
            // 
            // HistorialView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1338, 588);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnVolver);
            Controls.Add(TabHistorial);
            Name = "HistorialView";
            Text = "HistorialView";
            TabHistorial.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdVisitas).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdRutinas).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdMediciones).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdAumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabHistorial;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView GrdVisitas;
        private DataGridView GrdRutinas;
        private DataGridView GrdMediciones;
        private DataGridView GrdAumentos;
        private Button BtnVolver;
        private PictureBox pictureBox1;
        private Label label1;
    }
}