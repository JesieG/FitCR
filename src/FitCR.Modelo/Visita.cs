using System.Globalization;

namespace FitCR.Modelo
{
    /// <summary>
    /// Visita de un usuario al gimnasio.
    /// </summary>
    public class Visita
    {
        /// <summary>
        /// Crea una visita a partir de los textos de una linea del CSV.
        /// </summary>
        public Visita(string id, string idUsuario, string fecha)
        {
            Id = id;
            IdUsuario = idUsuario;
            Fecha = DateTime.Parse(fecha, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Identificador de la visita.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identificador del usuario que visito el gimnasio.
        /// </summary>
        public string IdUsuario { get; set; }

        /// <summary>
        /// Fecha de la visita.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Convierte la visita en una linea del CSV.
        /// </summary>
        public override string ToString()
        {
            return Id + "," + IdUsuario + "," + Fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
    }
}