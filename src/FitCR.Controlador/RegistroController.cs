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

            // El peso y la estatura se pueden escribir con coma o con punto.
            var pesoLimpio = NormalizarDecimal(peso);
            var estaturaLimpia = NormalizarDecimal(estatura);

            // Edad, peso y estatura tienen que ser numeros mayores que cero.
            if (!int.TryParse(edad, out int edadNumero) || edadNumero <= 0)
            {
                return false;
            }

            if (!double.TryParse(pesoLimpio, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double pesoNumero) || pesoNumero <= 0)
            {
                return false;
            }

            if (!double.TryParse(estaturaLimpia, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double estaturaNumero) || estaturaNumero <= 0)
            {
                return false;
            }

            // El nombre de usuario no puede repetirse, ni entre usuarios ni entre entrenadores.
            if (ExisteNombreDeUsuario(usuario))
            {
                return false;
            }

            // El nuevo id es la cantidad de usuarios que ya hay. Empieza sin rutinas.
            var nuevoId = InformationService.Usuarios.Count.ToString();
            var nuevo = new Usuario(nuevoId, nombre, usuario, contrasena, edad, pesoLimpio, estaturaLimpia, "{}");
            InformationService.Usuarios.Add(nuevo);

            return InformationService.UsuarioDataHandler.SaveData(Configuracion.RutaUsuarios, InformationService.Usuarios);
        }

        // Cambia la coma por punto y quita los espacios de los extremos.
        private static string NormalizarDecimal(string texto)
        {
            return texto.Trim().Replace(',', '.');
        }

        // Revisa si el nombre de usuario ya lo tiene un usuario o un entrenador.
        private bool ExisteNombreDeUsuario(string nombreUsuario)
        {
            foreach (var existente in InformationService.Usuarios)
            {
                if (existente.NombreUsuario == nombreUsuario)
                {
                    return true;
                }
            }

            foreach (var existente in InformationService.Entrenadores)
            {
                if (existente.NombreUsuario == nombreUsuario)
                {
                    return true;
                }
            }

            return false;
        }
    }
}