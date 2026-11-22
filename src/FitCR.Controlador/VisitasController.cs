using System.Globalization;
using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Registra las visitas de los usuarios al gimnasio.
    /// </summary>
    public class VisitasController
    {
        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public VisitasController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Registra la visita de hoy del usuario y la guarda en el archivo.
        /// </summary>
        /// <returns>True si se registro, false si no hay usuario o si ya registro una visita hoy.</returns>
        public bool RegistrarVisitaDeHoy(Usuario? usuario)
        {
            if (usuario == null || YaVisitoHoy(usuario))
            {
                return false;
            }

            var fecha = DateTime.Today.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            var visita = new Visita(CalcularNuevoId().ToString(), usuario.Id, fecha);

            InformationService.Visitas.Add(visita);

            return InformationService.VisitaDataHandler.SaveData(Configuracion.RutaVisitas, InformationService.Visitas);
        }

        /// <summary>
        /// Indica si el usuario ya registro una visita hoy.
        /// </summary>
        public bool YaVisitoHoy(Usuario usuario)
        {
            foreach (var visita in InformationService.Visitas)
            {
                if (visita.IdUsuario == usuario.Id && visita.Fecha.Date == DateTime.Today)
                {
                    return true;
                }
            }

            return false;
        }

        // El nuevo id es el mayor que ya existe mas uno.
        private int CalcularNuevoId()
        {
            var mayor = -1;

            foreach (var visita in InformationService.Visitas)
            {
                if (int.TryParse(visita.Id, out int id) && id > mayor)
                {
                    mayor = id;
                }
            }

            return mayor + 1;
        }
    }
}