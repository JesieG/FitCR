using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Arma las notificaciones del usuario o del entrenador que inicio sesion.
    /// </summary>
    public class NotificacionesController
    {
        // Visitas en una misma semana a partir de las cuales se avisa que hay que descansar.
        private const int VisitasParaDescansar = 5;

        // Dias de anticipacion con los que se avisa que una rutina vence o que toca una medicion.
        private const int DiasDeAviso = 7;

        // Cada cuantos dias se hace una medicion.
        private const int DiasEntreMediciones = 30;

        /// <summary>
        /// Crea el controlador con el servicio de datos y los controladores que calculan las insignias y las visitas.
        /// </summary>
        public NotificacionesController(
            InformationService informationService,
            InsigniasController insigniasController,
            EstadisticasController estadisticasController)
        {
            InformationService = informationService;
            InsigniasController = insigniasController;
            EstadisticasController = estadisticasController;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Controlador que calcula las insignias.
        /// </summary>
        public InsigniasController InsigniasController { get; set; }

        /// <summary>
        /// Controlador que cuenta las visitas.
        /// </summary>
        public EstadisticasController EstadisticasController { get; set; }

        /// <summary>
        /// Las notificaciones de quien inicio sesion, segun sea usuario o entrenador.
        /// </summary>
        public List<Notificacion> ObtenerNotificaciones()
        {
            if (InformationService.UsuarioActual != null)
            {
                return ObtenerNotificacionesDeUsuario(InformationService.UsuarioActual);
            }

            if (InformationService.EntrenadorActual != null)
            {
                return ObtenerNotificacionesDeEntrenador();
            }

            return new List<Notificacion>();
        }

        // Avisos del usuario: descanso, insignias ganadas e insignias de la verguenza.
        private List<Notificacion> ObtenerNotificacionesDeUsuario(Usuario usuario)
        {
            var notificaciones = new List<Notificacion>();

            var visitasDeLaSemana = EstadisticasController.ContarVisitas(usuario, ObtenerInicioDeSemana(), DateTime.Today);
            if (visitasDeLaSemana >= VisitasParaDescansar)
            {
                notificaciones.Add(new Notificacion($"Descansa esta semana: ya llevas {visitasDeLaSemana} visitas."));
            }

            foreach (var insignia in InsigniasController.ObtenerInsignias(usuario))
            {
                if (insignia.EsDeLaVerguenza)
                {
                    notificaciones.Add(new Notificacion($"Insignia de la verguenza: {insignia.Nombre}. {insignia.Descripcion}"));
                }
                else
                {
                    notificaciones.Add(new Notificacion($"Has ganado la insignia {insignia.Nombre}. {insignia.Descripcion}"));
                }
            }

            return notificaciones;
        }

        // Avisos del entrenador: rutinas por vencer y mediciones cercanas.
        private List<Notificacion> ObtenerNotificacionesDeEntrenador()
        {
            var notificaciones = new List<Notificacion>();

            AgregarRutinasPorVencer(notificaciones);
            AgregarMedicionesCercanas(notificaciones);

            return notificaciones;
        }

        // Una notificacion por cada rutina que vence en los proximos dias.
        private void AgregarRutinasPorVencer(List<Notificacion> notificaciones)
        {
            var limite = DateTime.Today.AddDays(DiasDeAviso);

            foreach (var rutina in InformationService.Rutinas)
            {
                if (rutina.FechaVigencia.Date >= DateTime.Today && rutina.FechaVigencia.Date <= limite)
                {
                    notificaciones.Add(new Notificacion(
                        $"La rutina {rutina.Nombre} de {BuscarNombreUsuario(rutina.IdUsuario)} vence el {rutina.FechaVigencia:dd/MM/yyyy}. Hay que cargar la nueva."));
                }
            }
        }

        // Una notificacion por cada usuario al que le toca una medicion en los proximos dias.
        private void AgregarMedicionesCercanas(List<Notificacion> notificaciones)
        {
            var limite = DateTime.Today.AddDays(DiasDeAviso);

            foreach (var usuario in InformationService.Usuarios)
            {
                var ultimaFecha = BuscarUltimaFechaDeMedicion(usuario);

                if (ultimaFecha == null)
                {
                    notificaciones.Add(new Notificacion($"{usuario.Nombre} todavia no tiene mediciones."));
                    continue;
                }

                var proxima = ultimaFecha.Value.AddDays(DiasEntreMediciones);
                if (proxima.Date <= limite)
                {
                    notificaciones.Add(new Notificacion($"A {usuario.Nombre} le toca una medicion el {proxima:dd/MM/yyyy}."));
                }
            }
        }

        // La semana empieza el lunes.
        private static DateTime ObtenerInicioDeSemana()
        {
            var hoy = DateTime.Today;
            var diasDesdeElLunes = ((int)hoy.DayOfWeek + 6) % 7;

            return hoy.AddDays(-diasDesdeElLunes);
        }

        // Nombre del usuario dueno de una rutina, o un texto si ya no existe.
        private string BuscarNombreUsuario(string idUsuario)
        {
            foreach (var usuario in InformationService.Usuarios)
            {
                if (usuario.Id == idUsuario)
                {
                    return usuario.Nombre;
                }
            }

            return "un usuario";
        }

        // Fecha de la medicion mas reciente del usuario. Es null si todavia no tiene ninguna.
        private DateTime? BuscarUltimaFechaDeMedicion(Usuario usuario)
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
    }
}