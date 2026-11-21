using FitCR.Controlador;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla con las clases que ofrece el gimnasio.
    /// </summary>
    public partial class ClasesView : Form
    {
        private ClasesController ClasesController { get; set; }

        /// <summary>
        /// Crea la pantalla con el controlador de clases.
        /// </summary>
        public ClasesView(ClasesController clasesController)
        {
            InitializeComponent();
            ClasesController = clasesController;

            ConfigurarTabla();
            CargarTabla();
        }

        private void CargarTabla()
        {
            GrdClases.Columns.Clear();
            GrdClases.Rows.Clear();
            GrdClases.Columns.Add("Nombre", "Clase");
            GrdClases.Columns.Add("Tipo", "Tipo");
            GrdClases.Columns.Add("Entrenador", "Entrenador");

            foreach (var clase in ClasesController.InformationService.Clases)
            {
                GrdClases.Rows.Add(
                    clase.Nombre,
                    clase.Tipo,
                    ClasesController.ObtenerNombreEntrenador(clase.IdEntrenador));
            }
        }

        // Las columnas se reparten todo el ancho y se oculta la columna vacia de la izquierda.
        private void ConfigurarTabla()
        {
            GrdClases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdClases.RowHeadersVisible = false;
            GrdClases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}