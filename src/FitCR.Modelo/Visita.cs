namespace FitCR.Modelo
{
    /// <summary>
    /// Visita de un usuario al gimnasio.
    /// </summary>
    public class Visita
    {
        /// <summary>
        /// Identificador de la visita.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Identificador del usuario que visito el gimnasio.
        /// </summary>
        public string IdUsuario { get; set; } = string.Empty;

        /// <summary>
        /// Fecha de la visita.
        /// </summary>
        public DateTime Fecha { get; set; }
    }
}