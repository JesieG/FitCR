using System.Globalization;
using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Registra las mediciones corporales de los usuarios.
    /// </summary>
    public class MedicionesController
    {
        // El porcentaje de grasa y de musculatura no puede pasar de 100.
        private const double PorcentajeMaximo = 100;

        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public MedicionesController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Valida los datos, crea la medicion y la guarda en el archivo.
        /// </summary>
        /// <returns>True si se registro, false si algun dato no es valido.</returns>
        public bool Registrar(Usuario? usuario, DateTime fecha, string peso, string grasa, string musculatura)
        {
            if (usuario == null || fecha.Date > DateTime.Today)
            {
                return false;
            }

            if (!LeerNumero(peso, out double pesoNumero) || pesoNumero <= 0)
            {
                return false;
            }

            if (!LeerPorcentaje(grasa, out double grasaNumero))
            {
                return false;
            }

            if (!LeerPorcentaje(musculatura, out double musculaturaNumero))
            {
                return false;
            }

            // El historial muestra primero lo mas reciente, por eso no se permite una fecha anterior a la ultima medicion.
            var ultimaFecha = ObtenerUltimaFecha(usuario);
            if (ultimaFecha != null && fecha.Date < ultimaFecha.Value.Date)
            {
                return false;
            }

            var medicion = new Medicion(
                CalcularNuevoId().ToString(),
                usuario.Id,
                fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                pesoNumero.ToString(CultureInfo.InvariantCulture),
                grasaNumero.ToString(CultureInfo.InvariantCulture),
                musculaturaNumero.ToString(CultureInfo.InvariantCulture));

            InformationService.Mediciones.Add(medicion);

            return InformationService.MedicionDataHandler.SaveData(Configuracion.RutaMediciones, InformationService.Mediciones);
        }

        // Lee un numero con decimales. Acepta coma o punto, y no acepta negativos ni letras.
        private static bool LeerNumero(string texto, out double numero)
        {
            var limpio = texto.Trim().Replace(',', '.');
            return double.TryParse(limpio, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out numero);
        }

        // Lee un porcentaje: tiene que ser mayor que cero y no pasar de 100.
        private static bool LeerPorcentaje(string texto, out double numero)
        {
            return LeerNumero(texto, out numero) && numero > 0 && numero <= PorcentajeMaximo;
        }

        // Fecha de la medicion mas reciente del usuario. Es null si todavia no tiene ninguna.
        private DateTime? ObtenerUltimaFecha(Usuario usuario)
        {
            DateTime? ultima = null;

            foreach (var medicion in InformationService.Mediciones)
            {
                if (medicion.IdUsuario == usuario.Id && (ultima == null || medicion.Fecha > ultima))
                {
                    ultima = medicion.Fecha;
                }
            }

            return ultima;
        }

        // El nuevo id es el mayor que ya existe mas uno.
        private int CalcularNuevoId()
        {
            var mayor = -1;

            foreach (var medicion in InformationService.Mediciones)
            {
                if (int.TryParse(medicion.Id, out int id) && id > mayor)
                {
                    mayor = id;
                }
            }

            return mayor + 1;
        }
    }
}