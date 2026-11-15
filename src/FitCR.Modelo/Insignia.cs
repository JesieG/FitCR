namespace FitCR.Modelo
{
    /// <summary>
    /// Insignia de logro o insignia de la verguenza.
    /// </summary>
    public class Insignia
    {
        /// <summary>
        /// Identificador de la insignia.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Nombre de la insignia.
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Indica si es una insignia de la verguenza.
        /// </summary>
        public bool EsDeLaVerguenza { get; set; }
    }
}