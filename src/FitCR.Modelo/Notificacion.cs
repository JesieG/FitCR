namespace FitCR.Modelo
{
    /// <summary>
    /// Mensaje que aparece en el timeline de un usuario o entrenador.
    /// </summary>
    public class Notificacion
    {
        /// <summary>
        /// Crea una notificacion con su mensaje. La fecha es el momento en que se genera.
        /// </summary>
        public Notificacion(string mensaje)
        {
            Mensaje = mensaje;
            Fecha = DateTime.Now;
        }

        /// <summary>
        /// Texto de la notificacion.
        /// </summary>
        public string Mensaje { get; set; }

        /// <summary>
        /// Fecha en que se genero la notificacion.
        /// </summary>
        public DateTime Fecha { get; set; }
    }
}