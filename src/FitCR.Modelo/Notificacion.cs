namespace FitCR.Modelo
{
    /// <summary>
    /// Mensaje que aparece en el timeline de un usuario o entrenador.
    /// </summary>
    public class Notificacion
    {
        /// <summary>
        /// Identificador de la notificacion.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Texto de la notificacion.
        /// </summary>
        public string Mensaje { get; set; } = string.Empty;

        /// <summary>
        /// Fecha en que se genero la notificacion.
        /// </summary>
        public DateTime Fecha { get; set; }
    }
}