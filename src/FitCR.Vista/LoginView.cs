using System.ComponentModel;
using FitCR.Controlador;
using FitCR.Modelo.Enums;

namespace FitCR.Vista
{
    /// <summary>
    /// Ventana de inicio de sesion.
    /// </summary>
    public partial class LoginView : Form
    {
        /// <summary>
        /// Crea la ventana con los controladores que necesita.
        /// </summary>
        public LoginView(LoginController loginController, RegistroController registroController)
        {
            LoginController = loginController;
            RegistroController = registroController;
            InitializeComponent();
        }

        /// <summary>
        /// Controlador que valida el inicio de sesion.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LoginController LoginController { get; set; }

        /// <summary>
        /// Controlador que registra usuarios nuevos.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RegistroController RegistroController { get; set; }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var resultado = LoginController.Login(TxtUsuario.Text, TxtContrasena.Text);

            if (!resultado)
            {
                MessageBox.Show("Usuario o contrasena incorrectos.");
                return;
            }

            // Cada rol tendra su propio menu. Por ahora solo se avisa quien entro.
            if (LoginController.InformationService.PersonaActual?.Rol == Rol.Entrenador)
            {
                MessageBox.Show("Bienvenido entrenador!");
            }
            else
            {
                MessageBox.Show("Bienvenido usuario!");
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            var registroView = new RegistroView(RegistroController);
            registroView.ShowDialog();
        }
    }
}