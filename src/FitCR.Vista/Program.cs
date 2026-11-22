using FitCR.Controlador;
using FitCR.Controlador.Abstracciones;
using FitCR.Modelo;

namespace FitCR.Vista
{
    /// <summary>
    /// Punto de entrada de la aplicacion.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Arma las piezas y abre la ventana de login. Si un archivo de datos falla, avisa y no abre.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            LoginView loginView;

            try
            {
                loginView = ArmarLogin();
            }
            catch (Exception ex) when (ex is IOException || ex is InvalidDataException)
            {
                MessageBox.Show(ex.Message, "No se pudo abrir Fit.CR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(loginView);
        }

        // Arma las piezas en orden: lectores, servicio, controladores y ventana de login.
        private static LoginView ArmarLogin()
        {
            IDataHandler<Usuario> usuarioHandler = new FileHandler<Usuario>();
            IDataHandler<Entrenador> entrenadorHandler = new FileHandler<Entrenador>();
            IDataHandler<Rutina> rutinaHandler = new FileHandler<Rutina>();
            IDataHandler<Visita> visitaHandler = new FileHandler<Visita>();
            IDataHandler<Medicion> medicionHandler = new FileHandler<Medicion>();
            IDataHandler<Clase> claseHandler = new FileHandler<Clase>();
            IDataHandler<Meta> metaHandler = new FileHandler<Meta>();
            IDataHandler<AumentoPeso> aumentoHandler = new FileHandler<AumentoPeso>();

            var informationService = new InformationService(
                usuarioHandler,
                entrenadorHandler,
                rutinaHandler,
                visitaHandler,
                medicionHandler,
                claseHandler,
                metaHandler,
                aumentoHandler);
            var loginController = new LoginController(informationService);
            var registroController = new RegistroController(informationService);

            return new LoginView(loginController, registroController);
        }
    }
}