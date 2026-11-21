using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Calcula las estadisticas del gimnasio para un rango de fechas.
    /// </summary>
    public class EstadisticasController
    {
        // Cantidad de usuarios que muestra cada top.
        private const int CantidadTop = 10;

        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public EstadisticasController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Revisa que la fecha inicial no sea mayor que la final.
        /// </summary>
        /// <returns>True si el rango es valido, false si no.</returns>
        public bool RangoValido(DateTime desde, DateTime hasta)
        {
            return desde.Date <= hasta.Date;
        }

        /// <summary>
        /// Los 10 usuarios con mas visitas en el rango de fechas.
        /// </summary>
        public List<VisitasPorUsuario> ObtenerTopVisitantes(DateTime desde, DateTime hasta)
        {
            var todos = ContarVisitasPorUsuario(desde, hasta);
            return TomarPrimeros(todos);
        }

        /// <summary>
        /// Los 10 usuarios con menos visitas en el rango de fechas.
        /// </summary>
        public List<VisitasPorUsuario> ObtenerTopAusentes(DateTime desde, DateTime hasta)
        {
            var todos = ContarVisitasPorUsuario(desde, hasta);

            // La lista viene de mayor a menor. Al darle vuelta, los que menos fueron quedan primero.
            todos.Reverse();
            return TomarPrimeros(todos);
        }

        /// <summary>
        /// Cuenta las visitas de un usuario que caen dentro del rango, sin tomar en cuenta la hora.
        /// </summary>
        public int ContarVisitas(Usuario usuario, DateTime desde, DateTime hasta)
        {
            var cantidad = 0;

            foreach (var visita in InformationService.Visitas)
            {
                if (visita.IdUsuario == usuario.Id && visita.Fecha.Date >= desde.Date && visita.Fecha.Date <= hasta.Date)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        // Arma la lista de todos los usuarios con su cantidad de visitas, de mayor a menor.
        private List<VisitasPorUsuario> ContarVisitasPorUsuario(DateTime desde, DateTime hasta)
        {
            var resultado = new List<VisitasPorUsuario>();

            foreach (var usuario in InformationService.Usuarios)
            {
                var cantidad = ContarVisitas(usuario, desde, hasta);
                resultado.Add(new VisitasPorUsuario(usuario.Nombre, cantidad));
            }

            resultado.Sort(new OrdenPorVisitas());
            return resultado;
        }

        // Se queda con los primeros 10 de la lista.
        private static List<VisitasPorUsuario> TomarPrimeros(List<VisitasPorUsuario> lista)
        {
            var resultado = new List<VisitasPorUsuario>();

            foreach (var elemento in lista)
            {
                if (resultado.Count >= CantidadTop)
                {
                    break;
                }

                resultado.Add(elemento);
            }

            return resultado;
        }
    }
}