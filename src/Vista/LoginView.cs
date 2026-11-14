using System;
using System.Windows.Forms;

namespace FitCR
{
    public partial class LoginView : Form
    {
        // Guarda el controlador que valida el login.
        public LoginController LoginController { get; set; }

        public LoginView(LoginController loginController)
        {
            LoginController = loginController;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}