using System;
using System.Windows.Forms;

namespace FitCR
{
    public partial class LoginView : Form
    {
        public LoginController LoginController { get; set; }
        public RegistroController RegistroController { get; set; }

        public LoginView(LoginController loginController, RegistroController registroController)
        {
            LoginController = loginController;
            RegistroController = registroController;
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var usuario = TxtUsuario.Text;
            var contrasena = TxtContrasena.Text;

            var resultado = LoginController.Login(usuario, contrasena);

            if (resultado)
            {
                MessageBox.Show("Bienvenido!");
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrectos.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registroView = new RegistroView(RegistroController);
            registroView.ShowDialog();
        }
    }
}