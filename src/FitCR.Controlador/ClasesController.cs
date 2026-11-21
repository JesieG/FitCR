namespace FitCR.Controlador
{
    /// <summary>
    /// Entrega la informacion de las clases del gimnasio.
    /// </summary>
    public class ClasesController
    {
        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public ClasesController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Nombre del entrenador a cargo de una clase, o un texto si no se encuentra.
        /// </summary>
        public string ObtenerNombreEntrenador(string idEntrenador)
        {
            foreach (var entrenador in InformationService.Entrenadores)
            {
                if (entrenador.Id == idEntrenador)
                {
                    return entrenador.Nombre;
                }
            }

            return "Sin entrenador";
        }
    }
}