using System.Globalization;
using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Registra usuarios nuevos en el sistema.
    /// </summary>
    public class RegistroController
    {
        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public RegistroController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Valida los datos, crea el usuario y lo guarda en el archivo.
        /// </summary>
        /// <returns>True si se registro, false si algun dato no es valido.</returns>
        public bool Registrar(string nombre, string usuario, string contrasena, string edad, string peso, string estatura)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return false;
            }

            // La coma separa los datos en el CSV, por eso no se permite en los textos.
            if (nombre.Contains(',') || usuario.Contains(',') || contrasena.Contains(','))
            {
                return false;
            }

            // Edad, peso y estatura tienen que ser numeros mayores que cero.
            if (!int.TryParse(edad, out int edadNumero) || edadNumero <= 0)
            {
                return false;
            }

            if (!double.TryParse(peso, NumberStyles.Float, CultureInfo.InvariantCulture, out double pesoNumero) || pesoNumero <= 0)
            {
                return false;
            }

            if (!double.TryParse(estatura, NumberStyles.Float, CultureInfo.InvariantCulture, out double estaturaNumero) || estaturaNumero <= 0)
            {
                return false;
            }

            // El nombre de usuario no puede repetirse, ni entre usuarios ni entre entrenadores.
            foreach (var existente in InformationService.Usuarios)
            {
                if (existente.NombreUsuario == usuario)
                {
                    return false;
                }
            }

            foreach (var existente in InformationService.Entrenadores)
            {
                if (existente.NombreUsuario == usuario)
                {
                    return false;
                }
            }

            // El nuevo id es la cantidad de usuarios que ya hay. Empieza sin rutinas.
            var nuevoId = InformationService.Usuarios.Count.ToString();
            var nuevo = new Usuario(nuevoId, nombre, usuario, contrasena, edad, peso, estatura, "{}");
            InformationService.Usuarios.Add(nuevo);

            return InformationService.UsuarioDataHandler.SaveData(Configuracion.RutaUsuarios, InformationService.Usuarios);
        }
    }
}