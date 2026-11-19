using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Entrega el historial del usuario: visitas, ultimas rutinas y mediciones.
    /// </summary>
    public class HistorialController
    {
        // Cantidad de rutinas que se muestran en la pestana de ultimas rutinas.
        private const int CantidadUltimasRutinas = 5;

        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public HistorialController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Visitas del usuario, de la mas reciente a la mas antigua.
        /// </summary>
        public List<Visita> ObtenerVisitas(Usuario usuario)
        {
            var resultado = new List<Visita>();

            // El archivo guarda las visitas de la mas antigua a la mas reciente, por eso se recorre al reves.
            for (var i = InformationService.Visitas.Count - 1; i >= 0; i--)
            {
                var visita = InformationService.Visitas[i];
                if (visita.IdUsuario == usuario.Id)
                {
                    resultado.Add(visita);
                }
            }

            return resultado;
        }

        /// <summary>
        /// Las ultimas 5 rutinas que se le asignaron al usuario.
        /// </summary>
        public List<Rutina> ObtenerUltimasRutinas(Usuario usuario)
        {
            var resultado = new List<Rutina>();

            // Las rutinas del usuario estan en el orden en que se le asignaron: las ultimas estan al final.
            for (var i = usuario.Rutinas.Count - 1; i >= 0; i--)
            {
                if (resultado.Count >= CantidadUltimasRutinas)
                {
                    break;
                }

                var rutina = BuscarRutina(usuario.Rutinas[i]);
                if (rutina != null)
                {
                    resultado.Add(rutina);
                }
            }

            return resultado;
        }

        /// <summary>
        /// Mediciones del usuario, de la mas reciente a la mas antigua.
        /// </summary>
        public List<Medicion> ObtenerMediciones(Usuario usuario)
        {
            var resultado = new List<Medicion>();

            // El archivo guarda las mediciones de la mas antigua a la mas reciente, por eso se recorre al reves.
            for (var i = InformationService.Mediciones.Count - 1; i >= 0; i--)
            {
                var medicion = InformationService.Mediciones[i];
                if (medicion.IdUsuario == usuario.Id)
                {
                    resultado.Add(medicion);
                }
            }

            return resultado;
        }

        // Busca una rutina por su identificador. Devuelve null si no existe.
        private Rutina? BuscarRutina(int id)
        {
            foreach (var rutina in InformationService.Rutinas)
            {
                if (rutina.Id == id.ToString())
                {
                    return rutina;
                }
            }

            return null;
        }
    }
}