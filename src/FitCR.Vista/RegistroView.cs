using System.ComponentModel;
using FitCR.Controlador;

namespace FitCR.Vista
{
    /// <summary>
    /// Ventana para crear una cuenta de usuario nueva.
    /// </summary>
    public partial class RegistroView : Form
    {
        /// <summary>
        /// Crea la ventana con el controlador que registra usuarios.
        /// </summary>
        public RegistroView(RegistroController registroController)
        {
            RegistroController = registroController;
            InitializeComponent();
        }

        /// <summary>
        /// Controlador que registra usuarios nuevos.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RegistroController RegistroController { get; set; }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var resultado = RegistroController.Registrar(
                TxtNombre.Text,
                TxtUsuario.Text,
                TxtContrasena.Text,
                TxtEdad.Text,
                TxtPeso.Text,
                TxtEstatura.Text);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado!");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar. Edad, peso y estatura deben ser numeros, o el usuario ya existe.");
            }
        }
    }
}