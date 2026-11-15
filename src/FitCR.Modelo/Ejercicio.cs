namespace FitCR.Modelo
{
    /// <summary>
    /// Ejercicio que forma parte de una rutina.
    /// </summary>
    public class Ejercicio
    {
        /// <summary>
        /// Identificador del ejercicio.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Nombre del ejercicio.
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Cantidad de series.
        /// </summary>
        public int Series { get; set; }

        /// <summary>
        /// Cantidad de repeticiones por serie.
        /// </summary>
        public int Repeticiones { get; set; }
    }
}