using FitCR.Controlador;

namespace FitCR.Vista
{
    /// <summary>
    /// Menu que ve el usuario despues de iniciar sesion.
    /// </summary>
    public partial class MenuUsuarioView : Form
    {
        private InformationService InformationService { get; set; }

        /// <summary>
        /// Crea el menu con el servicio que tiene la informacion de quien entro.
        /// </summary>
        public MenuUsuarioView(InformationService informationService)
        {
            InformationService = informationService;
            InitializeComponent();
            InicializarMensajes();
        }

        // Escribe el saludo con el nombre de quien inicio sesion.
        private void InicializarMensajes()
        {
            if (InformationService.UsuarioActual != null)
            {
                LblBienvenida.Text = $"Hola, {InformationService.UsuarioActual.Nombre}!";
            }
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            var perfil = new PerfilView(InformationService);
            perfil.ShowDialog();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Este metodo vacio lo busca el archivo de diseno.
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}