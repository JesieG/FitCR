using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Calcula cuanto avanzo un usuario hacia sus metas dentro de un rango de fechas.
    /// </summary>
    public class ObjetivosController
    {
        // Dias que se toman como un mes para calcular el promedio de visitas.
        private const double DiasPorMes = 30;

        private const string Cumplida = "Cumplida";
        private const string EnProgreso = "En progreso";
        private const string SinMejora = "Sin mejora";
        private const string PorDebajo = "Por debajo";
        private const string SinMediciones = "Sin mediciones";

        /// <summary>
        /// Crea el controlador con el servicio de datos y el controlador que cuenta las visitas.
        /// </summary>
        public ObjetivosController(InformationService informationService, EstadisticasController estadisticasController)
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
        /// El avance del usuario en cada una de sus metas. La lista queda vacia si no tiene metas.
        /// </summary>
        public List<ProgresoObjetivo> ObtenerProgreso(Usuario usuario, DateTime desde, DateTime hasta)
        {
            var resultado = new List<ProgresoObjetivo>();
            var meta = BuscarMeta(usuario);

            if (meta == null)
            {
                return resultado;
            }

            var primera = BuscarPrimeraMedicion(usuario, desde, hasta);
            var ultima = BuscarUltimaMedicion(usuario, desde, hasta);

            resultado.Add(ArmarGrasa(meta, primera, ultima));
            resultado.Add(ArmarMusculatura(meta, primera, ultima));
            resultado.Add(ArmarVisitas(usuario, meta, desde, hasta));

            return resultado;
        }

        // La grasa cumple la meta si esta en el objetivo o por debajo, y mejora si bajo.
        private static ProgresoObjetivo ArmarGrasa(Meta meta, Medicion? primera, Medicion? ultima)
        {
            if (primera == null || ultima == null)
            {
                return new ProgresoObjetivo("Grasa (%)", meta.GrasaObjetivo, null, null, SinMediciones);
            }

            var estado = CalcularEstado(ultima.Grasa <= meta.GrasaObjetivo, ultima.Grasa < primera.Grasa);
            return new ProgresoObjetivo("Grasa (%)", meta.GrasaObjetivo, primera.Grasa, ultima.Grasa, estado);
        }

        // La musculatura cumple la meta si llego al objetivo o lo paso, y mejora si subio.
        private static ProgresoObjetivo ArmarMusculatura(Meta meta, Medicion? primera, Medicion? ultima)
        {
            if (primera == null || ultima == null)
            {
                return new ProgresoObjetivo("Musculatura (%)", meta.MusculaturaObjetivo, null, null, SinMediciones);
            }

            var estado = CalcularEstado(ultima.Musculatura >= meta.MusculaturaObjetivo, ultima.Musculatura > primera.Musculatura);
            return new ProgresoObjetivo("Musculatura (%)", meta.MusculaturaObjetivo, primera.Musculatura, ultima.Musculatura, estado);
        }

        // Las visitas se comparan como un promedio por mes, porque la meta es mensual y el rango puede ser distinto.
        private ProgresoObjetivo ArmarVisitas(Usuario usuario, Meta meta, DateTime desde, DateTime hasta)
        {
            var visitas = EstadisticasController.ContarVisitas(usuario, desde, hasta);
            var dias = (hasta.Date - desde.Date).Days + 1;
            var promedio = visitas * DiasPorMes / dias;

            var estado = Cumplida;
            if (promedio < meta.VisitasPorMes)
            {
                estado = PorDebajo;
            }

            return new ProgresoObjetivo("Visitas por mes (promedio)", meta.VisitasPorMes, null, promedio, estado);
        }

        private static string CalcularEstado(bool cumplida, bool mejoro)
        {
            if (cumplida)
            {
                return Cumplida;
            }

            if (mejoro)
            {
                return EnProgreso;
            }

            return SinMejora;
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

        // La medicion mas antigua del usuario dentro del rango. Es null si no hay ninguna.
        private Medicion? BuscarPrimeraMedicion(Usuario usuario, DateTime desde, DateTime hasta)
        {
            Medicion? primera = null;

            foreach (var medicion in InformationService.Mediciones)
            {
                if (EstaEnElRango(medicion, usuario, desde, hasta) && (primera == null || medicion.Fecha < primera.Fecha))
                {
                    primera = medicion;
                }
            }

            return primera;
        }

        // La medicion mas reciente del usuario dentro del rango. Es null si no hay ninguna.
        private Medicion? BuscarUltimaMedicion(Usuario usuario, DateTime desde, DateTime hasta)
        {
            Medicion? ultima = null;

            foreach (var medicion in InformationService.Mediciones)
            {
                if (EstaEnElRango(medicion, usuario, desde, hasta) && (ultima == null || medicion.Fecha > ultima.Fecha))
                {
                    ultima = medicion;
                }
            }

            return ultima;
        }

        private static bool EstaEnElRango(Medicion medicion, Usuario usuario, DateTime desde, DateTime hasta)
        {
            return medicion.IdUsuario == usuario.Id && medicion.Fecha.Date >= desde.Date && medicion.Fecha.Date <= hasta.Date;
        }
    }
}