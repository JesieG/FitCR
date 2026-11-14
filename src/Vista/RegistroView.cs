using System;
using System.Windows.Forms;

namespace FitCR
{
    public partial class RegistroView : Form
    {
        public RegistroController RegistroController { get; set; }

        public RegistroView(RegistroController registroController)
        {
            RegistroController = registroController;
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var nombre = TxtNombre.Text;
            var usuario = TxtUsuario.Text;
            var contrasena = TxtContrasena.Text;
            var edad = TxtEdad.Text;
            var peso = TxtPeso.Text;
            var estatura = TxtEstatura.Text;

            var resultado = RegistroController.Registrar(nombre, usuario, contrasena, edad, peso, estatura);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado!");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar. Revisa los datos o el usuario ya existe.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void RegistroView_Load(object sender, EventArgs e)
        {
        }
    }
}