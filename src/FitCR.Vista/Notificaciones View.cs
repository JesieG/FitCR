using FitCR.Controlador;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla con el timeline de notificaciones de quien inicio sesion.
    /// </summary>
    public partial class NotificacionesView : Form
    {
        private NotificacionesController NotificacionesController { get; set; }

        /// <summary>
        /// Crea la pantalla con el controlador de notificaciones.
        /// </summary>
        public NotificacionesView(NotificacionesController notificacionesController)
        {
            InitializeComponent();
            NotificacionesController = notificacionesController;

            ConfigurarTabla();
            CargarTabla();
        }

        private void CargarTabla()
        {
            GrdNotificaciones.Columns.Clear();
            GrdNotificaciones.Rows.Clear();
            GrdNotificaciones.Columns.Add("Mensaje", "Mensaje");

            var notificaciones = NotificacionesController.ObtenerNotificaciones();

            foreach (var notificacion in notificaciones)
            {
                GrdNotificaciones.Rows.Add(notificacion.Mensaje);
            }

            if (notificaciones.Count == 0)
            {
                GrdNotificaciones.Rows.Add("No tienes notificaciones por ahora.");
            }

            LblResumen.Text = $"Total de notificaciones: {notificaciones.Count}";
        }

        // La columna ocupa todo el ancho, los textos largos pasan a la linea de abajo y se oculta la columna vacia de la izquierda.
        private void ConfigurarTabla()
        {
            GrdNotificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdNotificaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GrdNotificaciones.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GrdNotificaciones.RowHeadersVisible = false;
            GrdNotificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}