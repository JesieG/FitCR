using FitCR.Controlador;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla del entrenador para ver y registrar las mediciones de un usuario.
    /// </summary>
    public partial class MedicionesView : Form
    {
        private MedicionesController MedicionesController { get; set; }
        private HistorialController HistorialController { get; set; }

        /// <summary>
        /// Crea la pantalla con los controladores que necesita.
        /// </summary>
        public MedicionesView(MedicionesController medicionesController, HistorialController historialController)
        {
            InitializeComponent();
            MedicionesController = medicionesController;
            HistorialController = historialController;

            ConfigurarTabla();
            DtpFecha.Value = DateTime.Today;
            CboUsuario.DataSource = MedicionesController.InformationService.Usuarios;
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

            if (!MedicionesController.Registrar(usuario, DtpFecha.Value, TxtPeso.Text, TxtGrasa.Text, TxtMusculatura.Text))
            {
                MessageBox.Show(
                    "No se pudo registrar. Peso, grasa y musculatura deben ser numeros, los porcentajes no pueden pasar de 100, y la fecha no puede ser futura ni anterior a la ultima medicion del usuario.",
                    "Mediciones");
                return;
            }

            CargarTabla();
            LimpiarCampos();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarTabla()
        {
            GrdMediciones.Columns.Clear();
            GrdMediciones.Rows.Clear();
            GrdMediciones.Columns.Add("Fecha", "Fecha");
            GrdMediciones.Columns.Add("Peso", "Peso (kg)");
            GrdMediciones.Columns.Add("Grasa", "Grasa (%)");
            GrdMediciones.Columns.Add("Musculatura", "Musculatura (%)");

            var usuario = CboUsuario.SelectedItem as Usuario;

            if (usuario == null)
            {
                return;
            }

            foreach (var medicion in HistorialController.ObtenerMediciones(usuario))
            {
                GrdMediciones.Rows.Add(
                    medicion.Fecha.ToString("dd/MM/yyyy"),
                    medicion.Peso.ToString("0.0"),
                    medicion.Grasa.ToString("0.0"),
                    medicion.Musculatura.ToString("0.0"));
            }
        }

        private void LimpiarCampos()
        {
            TxtPeso.Clear();
            TxtGrasa.Clear();
            TxtMusculatura.Clear();
        }

        // Las columnas se reparten el ancho completo y se oculta la columna vacia de la izquierda.
        private void ConfigurarTabla()
        {
            GrdMediciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdMediciones.RowHeadersVisible = false;
            GrdMediciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}