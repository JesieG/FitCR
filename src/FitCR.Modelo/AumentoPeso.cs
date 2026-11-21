using System.Globalization;

namespace FitCR.Modelo
{
    /// <summary>
    /// Peso que un usuario levanto en un ejercicio en una fecha.
    /// </summary>
    public class AumentoPeso
    {
        /// <summary>
        /// Crea un registro a partir de los textos de una linea del CSV.
        /// </summary>
        public AumentoPeso(string id, string idUsuario, string ejercicio, string fecha, string peso)
        {
            Id = id;
            IdUsuario = idUsuario;
            Ejercicio = ejercicio;
            Fecha = DateTime.Parse(fecha, CultureInfo.InvariantCulture);
            Peso = double.Parse(peso, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Identificador del registro.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identificador del usuario que levanto el peso.
        /// </summary>
        public string IdUsuario { get; set; }

        /// <summary>
        /// Nombre del ejercicio.
        /// </summary>
        public string Ejercicio { get; set; }

        /// <summary>
        /// Fecha en que se registro el peso.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Peso levantado, en kilogramos.
        /// </summary>
        public double Peso { get; set; }
    }
}