using FitCR.Controlador;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla con las estadisticas del gimnasio y del usuario para un rango de fechas.
    /// </summary>
    public partial class EstadisticasView : Form
    {
        private EstadisticasController EstadisticasController { get; set; }
        private AumentosController AumentosController { get; set; }
        private ObjetivosController ObjetivosController { get; set; }

        /// <summary>
        /// Crea la pantalla con los controladores que necesita.
        /// </summary>
        public EstadisticasView(
            EstadisticasController estadisticasController,
            AumentosController aumentosController,
            ObjetivosController objetivosController)
        {
            InitializeComponent();
            EstadisticasController = estadisticasController;
            AumentosController = aumentosController;
            ObjetivosController = objetivosController;

            // Por defecto se muestran los ultimos tres meses.
            DtpHasta.Value = DateTime.Today;
            DtpDesde.Value = DateTime.Today.AddMonths(-3);

            ConfigurarTabla(GrdTopVisitantes);
            ConfigurarTabla(GrdTopAusentes);
            ConfigurarTabla(GrdAumentos);
            ConfigurarTabla(GrdObjetivos);
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
            var desde = DtpDesde.Value;
            var hasta = DtpHasta.Value;

            CargarTop(GrdTopVisitantes, EstadisticasController.ObtenerTopVisitantes(desde, hasta));
            CargarTop(GrdTopAusentes, EstadisticasController.ObtenerTopAusentes(desde, hasta));

            var usuario = EstadisticasController.InformationService.UsuarioActual;
            if (usuario != null)
            {
                CargarAumentos(usuario, desde, hasta);
                CargarObjetivos(usuario, desde, hasta);
            }
        }

        private static void CargarTop(DataGridView tabla, List<VisitasPorUsuario> datos)
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

        private void CargarAumentos(Usuario usuario, DateTime desde, DateTime hasta)
        {
            GrdAumentos.Columns.Clear();
            GrdAumentos.Rows.Clear();
            GrdAumentos.Columns.Add("Ejercicio", "Ejercicio");
            GrdAumentos.Columns.Add("PesoInicial", "Peso inicial (kg)");
            GrdAumentos.Columns.Add("PesoFinal", "Peso final (kg)");
            GrdAumentos.Columns.Add("Aumento", "Aumento (kg)");

            var resumenes = AumentosController.ObtenerAumentosPorEjercicio(usuario, desde, hasta);

            foreach (var resumen in resumenes)
            {
                GrdAumentos.Rows.Add(
                    resumen.Ejercicio,
                    FormatearNumero(resumen.PesoInicial),
                    FormatearNumero(resumen.PesoFinal),
                    FormatearCambio(resumen.Aumento));
            }

            if (resumenes.Count == 0)
            {
                GrdAumentos.Rows.Add("No hay registros de peso en ese rango de fechas.", string.Empty, string.Empty, string.Empty);
            }
        }

        private void CargarObjetivos(Usuario usuario, DateTime desde, DateTime hasta)
        {
            GrdObjetivos.Columns.Clear();
            GrdObjetivos.Rows.Clear();
            GrdObjetivos.Columns.Add("Meta", "Meta");
            GrdObjetivos.Columns.Add("Objetivo", "Objetivo");
            GrdObjetivos.Columns.Add("Inicio", "Al inicio");
            GrdObjetivos.Columns.Add("Final", "Al final");
            GrdObjetivos.Columns.Add("Cambio", "Cambio");
            GrdObjetivos.Columns.Add("Estado", "Estado");

            var progresos = ObjetivosController.ObtenerProgreso(usuario, desde, hasta);

            foreach (var progreso in progresos)
            {
                GrdObjetivos.Rows.Add(
                    progreso.Nombre,
                    FormatearNumero(progreso.Objetivo),
                    FormatearNumero(progreso.ValorInicial),
                    FormatearNumero(progreso.ValorFinal),
                    FormatearCambio(progreso.Cambio),
                    progreso.Estado);
            }

            if (progresos.Count == 0)
            {
                GrdObjetivos.Rows.Add("No tiene metas definidas.", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            }
        }

        // Si no hay valor se muestra un guion.
        private static string FormatearNumero(double? valor)
        {
            if (valor == null)
            {
                return "-";
            }

            return valor.Value.ToString("0.0");
        }

        // Si el valor subio se le pone el signo mas. Si no hay valor se muestra un guion.
        private static string FormatearCambio(double? cambio)
        {
            if (cambio == null)
            {
                return "-";
            }

            if (cambio.Value > 0)
            {
                return "+" + cambio.Value.ToString("0.0");
            }

            return cambio.Value.ToString("0.0");
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