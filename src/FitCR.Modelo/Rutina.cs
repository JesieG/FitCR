using System.Globalization;

namespace FitCR.Modelo
{
    /// <summary>
    /// Rutina de ejercicio asignada a un usuario.
    /// </summary>
    public class Rutina
    {
        /// <summary>
        /// Crea una rutina a partir de los textos de una linea del CSV.
        /// </summary>
        public Rutina(string id, string nombre, string idUsuario, string fechaVigencia)
        {
            Id = id;
            Nombre = nombre;
            IdUsuario = idUsuario;
            FechaVigencia = DateTime.Parse(fechaVigencia, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Identificador de la rutina.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Nombre de la rutina.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Identificador del usuario dueno de la rutina.
        /// </summary>
        public string IdUsuario { get; set; }

        /// <summary>
        /// Fecha hasta la que la rutina esta vigente.
        /// </summary>
        public DateTime FechaVigencia { get; set; }
    }
}