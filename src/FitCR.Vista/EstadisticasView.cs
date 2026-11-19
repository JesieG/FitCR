using FitCR.Controlador;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla con las estadisticas del gimnasio para un rango de fechas.
    /// </summary>
    public partial class EstadisticasView : Form
    {
        private EstadisticasController EstadisticasController { get; set; }

        /// <summary>
        /// Crea la pantalla con el controlador de estadisticas.
        /// </summary>
        public EstadisticasView(EstadisticasController estadisticasController)
        {
            InitializeComponent();
            EstadisticasController = estadisticasController;

            // Por defecto se muestran los ultimos tres meses.
            DtpHasta.Value = DateTime.Today;
            DtpDesde.Value = DateTime.Today.AddMonths(-3);

            ConfigurarTabla(GrdTopVisitantes);
            ConfigurarTabla(GrdTopAusentes);
            CargarEstadisticas();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (!EstadisticasController.RangoValido(DtpDesde.Value, DtpHasta.Value))
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.", "Fechas invalidas");
                return;
            }

            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            CargarTabla(GrdTopVisitantes, EstadisticasController.ObtenerTopVisitantes(DtpDesde.Value, DtpHasta.Value));
            CargarTabla(GrdTopAusentes, EstadisticasController.ObtenerTopAusentes(DtpDesde.Value, DtpHasta.Value));
        }

        private static void CargarTabla(DataGridView tabla, List<VisitasPorUsuario> datos)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("Nombre", "Nombre");
            tabla.Columns.Add("Visitas", "Visitas");

            foreach (var elemento in datos)
            {
                tabla.Rows.Add(elemento.Nombre, elemento.Cantidad);
            }
        }

        // Las columnas se reparten todo el ancho y se oculta la columna vacia de la izquierda.
        private static void ConfigurarTabla(DataGridView tabla)
        {
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.RowHeadersVisible = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}