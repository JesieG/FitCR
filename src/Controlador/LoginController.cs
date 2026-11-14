namespace FitCR
{
    // Revisa si el usuario y la contrasena son correctos.
    public class LoginController
    {
        public LoginController(InformationService informationService)
        {
            InformationService = informationService;
        }

        public InformationService InformationService { get; set; }

        public bool Login(string usuario, string contrasena)
        {
            // Si alguno viene vacio, no deja entrar.
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return false;
            }

            // Recorre los usuarios y busca uno que coincida.
            foreach (var elemento in InformationService.Usuarios)
            {
                if (elemento.NombreUsuario == usuario && elemento.Contrasena == contrasena)
                {
                    // Guarda quien entro y devuelve verdadero.
                    InformationService.UsuarioActual = elemento;
                    return true;
                }
            }

            return false;
        }
    }
}