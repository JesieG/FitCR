namespace FitCR
{
    // Registra un nuevo usuario en el sistema.
    public class RegistroController
    {
        public RegistroController(InformationService informationService)
        {
            InformationService = informationService;
        }

        public InformationService InformationService { get; set; }

        public bool Registrar(string nombre, string usuario, string contrasena, string edad, string peso, string estatura)
        {
            // Revisa que no vengan campos vacios.
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return false;
            }

            // La coma separa los datos en el CSV, por eso no se permite en los textos.
            if (nombre.Contains(",") || usuario.Contains(",") || contrasena.Contains(","))
            {
                return false;
            }

            // Revisa que el nombre de usuario no exista ya.
            foreach (var u in InformationService.Usuarios)
            {
                if (u.NombreUsuario == usuario)
                {
                    return false;
                }
            }

            // Calcula el nuevo id (la cantidad de usuarios que ya hay).
            var nuevoId = InformationService.Usuarios.Count.ToString();

            // Crea el usuario nuevo, sin rutinas al inicio.
            var nuevo = new Usuario(nuevoId, nombre, usuario, contrasena, edad, peso, estatura, "{}");
            InformationService.Usuarios.Add(nuevo);

            // Guarda la lista completa en el CSV.
            var guardador = new FileHandler<Usuario>();
            return guardador.SaveData(Configuracion.RutaUsuarios, InformationService.Usuarios);
        }
    }
}