using FitCR.Controlador;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla con el historial del usuario: visitas, ultimas rutinas, mediciones y control de aumentos.
    /// </summary>
    public partial class HistorialView : Form
    {
        private HistorialController HistorialController { get; set; }
        private AumentosController AumentosController { get; set; }

        /// <summary>
        /// Crea la pantalla con los controladores que necesita.
        /// </summary>
        public HistorialView(HistorialController historialController, AumentosController aumentosController)
        {
            InitializeComponent();
            HistorialController = historialController;
            AumentosController = aumentosController;

            var usuario = HistorialController.InformationService.UsuarioActual;
            if (usuario != null)
            {
                CargarVisitas(usuario);
                CargarRutinas(usuario);
                CargarMediciones(usuario);
                CargarAumentos(usuario);
            }
        }

        private void CargarVisitas(Usuario usuario)
        {
            ConfigurarTabla(GrdVisitas);
            GrdVisitas.Columns.Clear();
            GrdVisitas.Rows.Clear();
            GrdVisitas.Columns.Add("Fecha", "Fecha");

            foreach (var visita in HistorialController.ObtenerVisitas(usuario))
            {
                GrdVisitas.Rows.Add(visita.Fecha.ToString("dd/MM/yyyy"));
            }
        }

        private void CargarRutinas(Usuario usuario)
        {
            ConfigurarTabla(GrdRutinas);
            GrdRutinas.Columns.Clear();
            GrdRutinas.Rows.Clear();
            GrdRutinas.Columns.Add("Nombre", "Nombre");
            GrdRutinas.Columns.Add("Vigencia", "Vigencia hasta");

            foreach (var rutina in HistorialController.ObtenerUltimasRutinas(usuario))
            {
                GrdRutinas.Rows.Add(rutina.Nombre, rutina.FechaVigencia.ToString("dd/MM/yyyy"));
            }
        }

        private void CargarMediciones(Usuario usuario)
        {
            ConfigurarTabla(GrdMediciones);
            GrdMediciones.Columns.Clear();
            GrdMediciones.Rows.Clear();
            GrdMediciones.Columns.Add("Fecha", "Fecha");
            GrdMediciones.Columns.Add("Peso", "Peso (kg)");
            GrdMediciones.Columns.Add("Grasa", "Grasa (%)");
            GrdMediciones.Columns.Add("Musculatura", "Musculatura (%)");

            foreach (var medicion in HistorialController.ObtenerMediciones(usuario))
            {
                GrdMediciones.Rows.Add(
                    medicion.Fecha.ToString("dd/MM/yyyy"),
                    medicion.Peso.ToString("0.0"),
                    medicion.Grasa.ToString("0.0"),
                    medicion.Musculatura.ToString("0.0"));
            }
        }

        private void CargarAumentos(Usuario usuario)
        {
            ConfigurarTabla(GrdAumentos);
            GrdAumentos.Columns.Clear();
            GrdAumentos.Rows.Clear();
            GrdAumentos.Columns.Add("Fecha", "Fecha");
            GrdAumentos.Columns.Add("Ejercicio", "Ejercicio");
            GrdAumentos.Columns.Add("Peso", "Peso (kg)");
            GrdAumentos.Columns.Add("Aumento", "Aumento (kg)");
            GrdAumentos.Columns[1].FillWeight = 180;

            foreach (var registro in AumentosController.ObtenerAumentos(usuario))
            {
                GrdAumentos.Rows.Add(
                    registro.Fecha.ToString("dd/MM/yyyy"),
                    registro.Ejercicio,
                    registro.Peso.ToString("0.0"),
                    FormatearAumento(AumentosController.CalcularAumento(registro)));
            }
        }

        // Si no hay registro anterior es el primero del ejercicio. Si subio se le pone el signo mas.
        private static string FormatearAumento(double? aumento)
        {
            if (aumento == null)
            {
                return "Primer registro";
            }

            if (aumento.Value > 0)
            {
                return "+" + aumento.Value.ToString("0.0");
            }

            return aumento.Value.ToString("0.0");
        }

        // Las columnas se reparten el ancho completo y se oculta la columna vacia de la izquierda.
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