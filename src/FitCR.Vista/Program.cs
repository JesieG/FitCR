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
        /// Arma las piezas en orden y abre la ventana de login.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IDataHandler<Usuario> usuarioHandler = new FileHandler<Usuario>();
            IDataHandler<Entrenador> entrenadorHandler = new FileHandler<Entrenador>();
            var informationService = new InformationService(usuarioHandler, entrenadorHandler);
            var loginController = new LoginController(informationService);
            var registroController = new RegistroController(informationService);
            var loginView = new LoginView(loginController, registroController);

            Application.Run(loginView);
        }
    }
}