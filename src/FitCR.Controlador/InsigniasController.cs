using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Calcula las insignias de logro y de la verguenza de un usuario.
    /// </summary>
    public class InsigniasController
    {
        // Cantidad de dias hacia atras que se toman en cuenta para las visitas y las mediciones.
        private const int DiasEvaluados = 30;

        // Cantidad de usuarios que forman el grupo de los que menos visitan.
        private const int CantidadAusentes = 10;

        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos y el que cuenta las visitas.
        /// </summary>
        public InsigniasController(InformationService informationService, EstadisticasController estadisticasController)
        {
            InformationService = informationService;
            EstadisticasController = estadisticasController;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Controlador que cuenta las visitas de cada usuario.
        /// </summary>
        public EstadisticasController EstadisticasController { get; set; }

        /// <summary>
        /// Las insignias que tiene el usuario hoy: primero las de logro y despues las de la verguenza.
        /// </summary>
        public List<Insignia> ObtenerInsignias(Usuario usuario)
        {
            var insignias = new List<Insignia>();
            var desde = DateTime.Today.AddDays(-DiasEvaluados);
            var visitas = EstadisticasController.ContarVisitas(usuario, desde, DateTime.Today);
            var ultimaMedicion = BuscarUltimaMedicion(usuario);

            AgregarInsigniasDeLogro(insignias, usuario, visitas, ultimaMedicion);
            AgregarInsigniasDeLaVerguenza(insignias, usuario, desde, visitas, ultimaMedicion);

            return insignias;
        }

        // Una insignia de logro por cada meta que el usuario cumple.
        private void AgregarInsigniasDeLogro(List<Insignia> insignias, Usuario usuario, int visitas, Medicion? ultimaMedicion)
        {
            var meta = BuscarMeta(usuario);

            if (meta == null)
            {
                return;
            }

            if (ultimaMedicion != null && ultimaMedicion.Grasa <= meta.GrasaObjetivo)
            {
                insignias.Add(new Insignia(
                    "Meta de grasa",
                    $"Tu grasa ({ultimaMedicion.Grasa:0.0}%) esta en tu meta de {meta.GrasaObjetivo:0.0}% o por debajo.",
                    false));
            }

            if (ultimaMedicion != null && ultimaMedicion.Musculatura >= meta.MusculaturaObjetivo)
            {
                insignias.Add(new Insignia(
                    "Meta de musculatura",
                    $"Tu musculatura ({ultimaMedicion.Musculatura:0.0}%) llego a tu meta de {meta.MusculaturaObjetivo:0.0}%.",
                    false));
            }

            if (visitas >= meta.VisitasPorMes)
            {
                insignias.Add(new Insignia(
                    "Meta de visitas",
                    $"Visitaste el gimnasio {visitas} veces en los ultimos {DiasEvaluados} dias y tu meta era {meta.VisitasPorMes}.",
                    false));
            }
        }

        // Una insignia de la verguenza por cada cosa que el usuario no cumple.
        private void AgregarInsigniasDeLaVerguenza(List<Insignia> insignias, Usuario usuario, DateTime desde, int visitas, Medicion? ultimaMedicion)
        {
            var logros = insignias.Count;

            if (EstaEntreLosQueMenosVisitan(usuario, desde, visitas))
            {
                insignias.Add(new Insignia(
                    "Poca asistencia",
                    $"Estas entre los {CantidadAusentes} usuarios que menos visitaron el gimnasio en los ultimos {DiasEvaluados} dias.",
                    true));
            }

            if (ultimaMedicion == null || ultimaMedicion.Fecha.Date < desde.Date)
            {
                insignias.Add(new Insignia(
                    "Sin progreso",
                    $"No tenes mediciones en los ultimos {DiasEvaluados} dias.",
                    true));
            }

            if (BuscarMeta(usuario) != null && logros == 0)
            {
                insignias.Add(new Insignia(
                    "Objetivos sin cumplir",
                    "No cumpliste ninguna de tus metas.",
                    true));
            }
        }

        // El usuario esta entre los que menos visitan si hay menos de 10 usuarios con menos visitas que el.
        private bool EstaEntreLosQueMenosVisitan(Usuario usuario, DateTime desde, int visitas)
        {
            var conMenosVisitas = 0;

            foreach (var otro in InformationService.Usuarios)
            {
                if (otro.Id != usuario.Id && EstadisticasController.ContarVisitas(otro, desde, DateTime.Today) < visitas)
                {
                    conMenosVisitas++;
                }
            }

            return conMenosVisitas < CantidadAusentes;
        }

        // Busca la meta del usuario. Devuelve null si no tiene.
        private Meta? BuscarMeta(Usuario usuario)
        {
            foreach (var meta in InformationService.Metas)
            {
                if (meta.IdUsuario == usuario.Id)
                {
                    return meta;
                }
            }

            return null;
        }

        // Busca la medicion mas reciente del usuario. Devuelve null si no tiene ninguna.
        private Medicion? BuscarUltimaMedicion(Usuario usuario)
        {
            Medicion? ultima = null;

            foreach (var medicion in InformationService.Mediciones)
            {
                if (medicion.IdUsuario == usuario.Id && (ultima == null || medicion.Fecha > ultima.Fecha))
                {
                    ultima = medicion;
                }
            }

            return ultima;
        }
    }
}