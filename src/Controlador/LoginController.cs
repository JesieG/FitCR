namespace FitCR
{
    // Revisa si el usuario y la contrasena son correctos y dice que rol tiene.
    public class LoginController
    {
        public LoginController(InformationService informationService)
        {
            InformationService = informationService;
        }

        public InformationService InformationService { get; set; }

        // Devuelve "usuario", "entrenador" o "" si los datos son incorrectos.
        public string Login(string usuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return "";
            }

            // Primero busca entre los usuarios.
            foreach (var elemento in InformationService.Usuarios)
            {
                if (elemento.NombreUsuario == usuario && elemento.Contrasena == contrasena)
                {
                    InformationService.UsuarioActual = elemento;
                    InformationService.EntrenadorActual = null;
                    return "usuario";
                }
            }

            // Si no esta, busca entre los entrenadores.
            foreach (var elemento in InformationService.Entrenadores)
            {
                if (elemento.NombreUsuario == usuario && elemento.Contrasena == contrasena)
                {
                    InformationService.EntrenadorActual = elemento;
                    InformationService.UsuarioActual = null;
                    return "entrenador";
                }
            }

            return "";
        }
    }
}