namespace FitCR.Modelo
{
    /// <summary>
    /// Clase que ofrece el gimnasio: yoga, crossfit, zumba, spinning o gimnasio abierto.
    /// </summary>
    public class Clase
    {
        /// <summary>
        /// Identificador de la clase.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Nombre de la clase.
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Tipo de clase.
        /// </summary>
        public string Tipo { get; set; } = string.Empty;
    }
}