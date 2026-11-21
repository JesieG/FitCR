using FitCR.Controlador;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla del entrenador para agregar, editar y eliminar rutinas.
    /// </summary>
    public partial class RutinasView : Form
    {
        private RutinasController RutinasController { get; set; }

        /// <summary>
        /// Crea la pantalla con el controlador de rutinas.
        /// </summary>
        public RutinasView(RutinasController rutinasController)
        {
            InitializeComponent();
            RutinasController = rutinasController;

            CboUsuario.DataSource = RutinasController.InformationService.Usuarios;
            CboUsuario.DisplayMember = "Nombre";
            DtpVigencia.Value = DateTime.Today.AddMonths(1);

            ConfigurarTabla();
            CargarTabla();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var usuario = CboUsuario.SelectedItem as Usuario;

            if (!RutinasController.Agregar(TxtNombre.Text, usuario, DtpVigencia.Value))
            {
                MessageBox.Show(
                    "No se pudo agregar. El nombre no puede estar vacio ni tener comas, hay que elegir un usuario y la vigencia no puede ser una fecha pasada.",
                    "Rutinas");
                return;
            }

            CargarTabla();
            TxtNombre.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var rutina = ObtenerRutinaSeleccionada();

            if (rutina == null)
            {
                MessageBox.Show("Seleccione una rutina de la tabla.", "Rutinas");
                return;
            }

            var usuario = CboUsuario.SelectedItem as Usuario;

            if (!RutinasController.Editar(rutina, TxtNombre.Text, usuario, DtpVigencia.Value))
            {
                MessageBox.Show("No se pudo editar. El nombre no puede estar vacio ni tener comas, y hay que elegir un usuario.", "Rutinas");
                return;
            }

            CargarTabla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var rutina = ObtenerRutinaSeleccionada();

            if (rutina == null)
            {
                MessageBox.Show("Seleccione una rutina de la tabla.", "Rutinas");
                return;
            }

            var respuesta = MessageBox.Show(
                $"Se va a eliminar la rutina {rutina.Nombre}. Desea continuar?",
                "Rutinas",
                MessageBoxButtons.YesNo);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            if (!RutinasController.Eliminar(rutina))
            {
                MessageBox.Show("No se pudo eliminar la rutina.", "Rutinas");
                return;
            }

            CargarTabla();
        }

        // Al elegir una fila, sus datos pasan a los campos para poder editarlos.
        private void GrdRutinas_SelectionChanged(object sender, EventArgs e)
        {
            var rutina = ObtenerRutinaSeleccionada();

            if (rutina == null)
            {
                return;
            }

            TxtNombre.Text = rutina.Nombre;
            DtpVigencia.Value = rutina.FechaVigencia;
            CboUsuario.SelectedItem = RutinasController.BuscarUsuario(rutina.IdUsuario);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Devuelve la rutina de la fila elegida, o null si no hay ninguna.
        private Rutina? ObtenerRutinaSeleccionada()
        {
            if (GrdRutinas.CurrentRow == null)
            {
                return null;
            }

            var id = GrdRutinas.CurrentRow.Cells[0].Value?.ToString();

            if (id == null)
            {
                return null;
            }

            return RutinasController.BuscarRutina(id);
        }

        private void CargarTabla()
        {
            GrdRutinas.Columns.Clear();
            GrdRutinas.Rows.Clear();
            GrdRutinas.Columns.Add("Id", "Id");
            GrdRutinas.Columns.Add("Nombre", "Nombre");
            GrdRutinas.Columns.Add("Usuario", "Usuario");
            GrdRutinas.Columns.Add("Vigencia", "Vigencia hasta");

            foreach (var rutina in RutinasController.InformationService.Rutinas)
            {
                GrdRutinas.Rows.Add(
                    rutina.Id,
                    rutina.Nombre,
                    RutinasController.ObtenerNombreUsuario(rutina.IdUsuario),
                    rutina.FechaVigencia.ToString("dd/MM/yyyy"));
            }
        }

        // Las columnas se reparten todo el ancho, se oculta la columna vacia de la izquierda y se elige una fila a la vez.
        private void ConfigurarTabla()
        {
            GrdRutinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdRutinas.RowHeadersVisible = false;
            GrdRutinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrdRutinas.MultiSelect = false;
        }
    }
}