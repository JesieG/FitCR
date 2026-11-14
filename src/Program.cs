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

            var informationService = new InformationService();
            var loginController = new LoginController(informationService);
            var registroController = new RegistroController(informationService);
            var loginView = new LoginView(loginController, registroController);

            Application.Run(loginView);
        }
    }
}