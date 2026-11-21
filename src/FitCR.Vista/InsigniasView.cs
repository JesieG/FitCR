using FitCR.Controlador;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla con las insignias de logro y de la verguenza del usuario.
    /// </summary>
    public partial class InsigniasView : Form
    {
        private InsigniasController InsigniasController { get; set; }

        /// <summary>
        /// Crea la pantalla con el controlador de insignias.
        /// </summary>
        public InsigniasView(InsigniasController insigniasController)
        {
            InitializeComponent();
            InsigniasController = insigniasController;

            ConfigurarTabla(GrdLogros);
            ConfigurarTabla(GrdVerguenza);

            var usuario = InsigniasController.InformationService.UsuarioActual;
            if (usuario != null)
            {
                CargarInsignias(usuario);
            }
        }

        // Separa las insignias en las de logro y las de la verguenza, y llena cada tabla.
        private void CargarInsignias(Usuario usuario)
        {
            var logros = new List<Insignia>();
            var verguenza = new List<Insignia>();

            foreach (var insignia in InsigniasController.ObtenerInsignias(usuario))
            {
                if (insignia.EsDeLaVerguenza)
                {
                    verguenza.Add(insignia);
                }
                else
                {
                    logros.Add(insignia);
                }
            }

            CargarTabla(GrdLogros, logros, "Todavia no tiene insignias de logro.");
            CargarTabla(GrdVerguenza, verguenza, "No tiene insignias de la verguenza.");
        }

        private static void CargarTabla(DataGridView tabla, List<Insignia> insignias, string mensajeVacio)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("Nombre", "Insignia");
            tabla.Columns.Add("Descripcion", "Por que");
            tabla.Columns[0].FillWeight = 60;
            tabla.Columns[1].FillWeight = 140;

            if (insignias.Count == 0)
            {
                tabla.Rows.Add(mensajeVacio, string.Empty);
                return;
            }

            foreach (var insignia in insignias)
            {
                tabla.Rows.Add(insignia.Nombre, insignia.Descripcion);
            }
        }

        // Las columnas se reparten el ancho, los textos largos pasan a la linea de abajo y se oculta la columna vacia de la izquierda.
        private static void ConfigurarTabla(DataGridView tabla)
        {
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tabla.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tabla.RowHeadersVisible = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}