using System;
using System.Windows.Forms;

namespace FitCR
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Arma las piezas en orden, igual que el profe.
            var informationService = new InformationService();
            var loginController = new LoginController(informationService);
            var loginView = new LoginView(loginController);

            // Abre la ventana de login al arrancar.
            Application.Run(loginView);
        }
    }
}