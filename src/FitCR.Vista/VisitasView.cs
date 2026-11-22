using FitCR.Controlador;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla del entrenador para ver y registrar las visitas de un usuario al gimnasio.
    /// </summary>
    public partial class VisitasView : Form
    {
        private VisitasController VisitasController { get; set; }
        private HistorialController HistorialController { get; set; }

        /// <summary>
        /// Crea la pantalla con los controladores que necesita.
        /// </summary>
        public VisitasView(VisitasController visitasController, HistorialController historialController)
        {
            InitializeComponent();
            VisitasController = visitasController;
            HistorialController = historialController;

            ConfigurarTabla();
            CboUsuario.DataSource = VisitasController.InformationService.Usuarios;
            CboUsuario.DisplayMember = "Nombre";
            CargarTabla();
        }

        private void CboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var usuario = CboUsuario.SelectedItem as Usuario;

            if (!VisitasController.RegistrarVisitaDeHoy(usuario))
            {
                MessageBox.Show(
                    "No se pudo registrar. Hay que elegir un usuario, y ese usuario no puede tener ya una visita registrada hoy.",
                    "Visitas");
                return;
            }

            CargarTabla();
            MessageBox.Show("Visita registrada.", "Visitas");
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarTabla()
        {
            GrdVisitas.Columns.Clear();
            GrdVisitas.Rows.Clear();
            GrdVisitas.Columns.Add("Fecha", "Fecha");

            var usuario = CboUsuario.SelectedItem as Usuario;

            if (usuario == null)
            {
                return;
            }

            foreach (var visita in HistorialController.ObtenerVisitas(usuario))
            {
                GrdVisitas.Rows.Add(visita.Fecha.ToString("dd/MM/yyyy"));
            }
        }

        // La columna ocupa todo el ancho y se oculta la columna vacia de la izquierda.
        private void ConfigurarTabla()
        {
            GrdVisitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdVisitas.RowHeadersVisible = false;
            GrdVisitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}