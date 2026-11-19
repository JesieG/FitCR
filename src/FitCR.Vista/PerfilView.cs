using FitCR.Controlador;

namespace FitCR.Vista
{
    /// <summary>
    /// Pantalla con los datos del usuario y su IMC.
    /// </summary>
    public partial class PerfilView : Form
    {
        private InformationService InformationService { get; set; }

        /// <summary>
        /// Crea la pantalla con el servicio que tiene la informacion de quien entro.
        /// </summary>
        public PerfilView(InformationService informationService)
        {
            InformationService = informationService;
            InitializeComponent();
            InicializarMensajes();
        }

        // Muestra los datos del usuario que inicio sesion.
        private void InicializarMensajes()
        {
            var usuario = InformationService.UsuarioActual;

            if (usuario == null)
            {
                return;
            }

            LblNombre.Text = usuario.Nombre;
            LblUsuario.Text = usuario.NombreUsuario;
            LblEdad.Text = $"{usuario.Edad} anos";
            LblPeso.Text = $"{usuario.Peso:0.0} kg";
            LblEstatura.Text = $"{usuario.Estatura:0.00} m";
            LblImc.Text = usuario.Imc.ToString("0.0");
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}