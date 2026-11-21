namespace FitCR.Modelo
{
    /// <summary>
    /// Insignia de logro o insignia de la verguenza.
    /// </summary>
    public class Insignia
    {
        /// <summary>
        /// Crea una insignia con su nombre, su descripcion y su tipo.
        /// </summary>
        public Insignia(string nombre, string descripcion, bool esDeLaVerguenza)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            EsDeLaVerguenza = esDeLaVerguenza;
        }

        /// <summary>
        /// Nombre de la insignia.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Por que se obtuvo la insignia.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Indica si es una insignia de la verguenza.
        /// </summary>
        public bool EsDeLaVerguenza { get; set; }
    }
}