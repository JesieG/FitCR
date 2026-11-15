using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Revisa si el usuario y la contrasena son correctos.
    /// </summary>
    public class LoginController
    {
        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public LoginController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Busca al usuario o entrenador y guarda quien entro.
        /// </summary>
        /// <returns>True si los datos son correctos, false si no.</returns>
        public bool Login(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return false;
            }

            foreach (var usuario in InformationService.Usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.Contrasena == contrasena)
                {
                    InformationService.PersonaActual = usuario;
                    return true;
                }
            }

            foreach (var entrenador in InformationService.Entrenadores)
            {
                if (entrenador.NombreUsuario == nombreUsuario && entrenador.Contrasena == contrasena)
                {
                    InformationService.PersonaActual = entrenador;
                    return true;
                }
            }

            return false;
        }
    }
}