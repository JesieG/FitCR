using FitCR.Controlador;

namespace FitCR.Vista
{
    /// <summary>
    /// Menu que ve el usuario despues de iniciar sesion.
    /// </summary>
    public partial class MenuUsuarioView : Form
    {
        private InformationService InformationService { get; set; }

        /// <summary>
        /// Crea el menu con el servicio que tiene la informacion de quien entro.
        /// </summary>
        public MenuUsuarioView(InformationService informationService)
        {
            InformationService = informationService;
            InitializeComponent();
            InicializarMensajes();
        }

        // Escribe el saludo con el nombre de quien inicio sesion.
        private void InicializarMensajes()
        {
            if (InformationService.UsuarioActual != null)
            {
                LblBienvenida.Text = $"Hola, {InformationService.UsuarioActual.Nombre}!";
            }
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            var perfil = new PerfilView(InformationService);
            perfil.ShowDialog();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            var historialController = new HistorialController(InformationService);
            var aumentosController = new AumentosController(InformationService);
            var historialView = new HistorialView(historialController, aumentosController);
            historialView.ShowDialog();
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            var estadisticasController = new EstadisticasController(InformationService);
            var aumentosController = new AumentosController(InformationService);
            var objetivosController = new ObjetivosController(InformationService, estadisticasController);
            var estadisticasView = new EstadisticasView(estadisticasController, aumentosController, objetivosController);
            estadisticasView.ShowDialog();
        }

        private void BtnInsignias_Click(object sender, EventArgs e)
        {
            var estadisticasController = new EstadisticasController(InformationService);
            var insigniasController = new InsigniasController(InformationService, estadisticasController);
            var insigniasView = new InsigniasView(insigniasController);
            insigniasView.ShowDialog();
        }

        private void BtnClases_Click(object sender, EventArgs e)
        {
            var clasesController = new ClasesController(InformationService);
            var clasesView = new ClasesView(clasesController);
            clasesView.ShowDialog();
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