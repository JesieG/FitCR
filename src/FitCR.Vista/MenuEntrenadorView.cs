using FitCR.Controlador;

namespace FitCR.Vista
{
    /// <summary>
    /// Menu que ve el entrenador despues de iniciar sesion.
    /// </summary>
    public partial class MenuEntrenadorView : Form
    {
        private InformationService InformationService { get; set; }

        /// <summary>
        /// Crea el menu con el servicio que tiene la informacion de quien entro.
        /// </summary>
        public MenuEntrenadorView(InformationService informationService)
        {
            InformationService = informationService;
            InitializeComponent();
            InicializarMensajes();
        }

        // Escribe el saludo y el tipo de entrenador de quien inicio sesion.
        private void InicializarMensajes()
        {
            if (InformationService.EntrenadorActual != null)
            {
                LblBienvenida.Text = $"Hola, {InformationService.EntrenadorActual.Nombre}!";
                LblTipo.Text = $"Tipo de entrenador: {InformationService.EntrenadorActual.Tipo}";
            }
        }

        private void BtnRutinas_Click(object sender, EventArgs e)
        {
            var rutinasController = new RutinasController(InformationService);
            var rutinasView = new RutinasView(rutinasController);
            rutinasView.ShowDialog();
        }

        private void BtnMediciones_Click(object sender, EventArgs e)
        {
            var medicionesController = new MedicionesController(InformationService);
            var historialController = new HistorialController(InformationService);
            var medicionesView = new MedicionesView(medicionesController, historialController);
            medicionesView.ShowDialog();
        }

        private void BtnNotificaciones_Click(object sender, EventArgs e)
        {
            var estadisticasController = new EstadisticasController(InformationService);
            var insigniasController = new InsigniasController(InformationService, estadisticasController);
            var notificacionesController = new NotificacionesController(InformationService, insigniasController, estadisticasController);
            var notificacionesView = new NotificacionesView(notificacionesController);
            notificacionesView.ShowDialog();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}