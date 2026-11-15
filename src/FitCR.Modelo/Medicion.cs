namespace FitCR.Modelo
{
    /// <summary>
    /// Medicion corporal de un usuario en una fecha.
    /// </summary>
    public class Medicion
    {
        /// <summary>
        /// Identificador de la medicion.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Identificador del usuario medido.
        /// </summary>
        public string IdUsuario { get; set; } = string.Empty;

        /// <summary>
        /// Fecha de la medicion.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Peso en kilogramos.
        /// </summary>
        public double Peso { get; set; }

        /// <summary>
        /// Porcentaje de grasa.
        /// </summary>
        public double Grasa { get; set; }

        /// <summary>
        /// Porcentaje de musculatura.
        /// </summary>
        public double Musculatura { get; set; }
    }
}