using System.Globalization;

namespace FitCR.Modelo
{
    /// <summary>
    /// Medicion corporal de un usuario en una fecha.
    /// </summary>
    public class Medicion
    {
        /// <summary>
        /// Crea una medicion a partir de los textos de una linea del CSV.
        /// </summary>
        public Medicion(string id, string idUsuario, string fecha, string peso, string grasa, string musculatura)
        {
            Id = id;
            IdUsuario = idUsuario;
            Fecha = DateTime.Parse(fecha, CultureInfo.InvariantCulture);
            Peso = double.Parse(peso, CultureInfo.InvariantCulture);
            Grasa = double.Parse(grasa, CultureInfo.InvariantCulture);
            Musculatura = double.Parse(musculatura, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Identificador de la medicion.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identificador del usuario medido.
        /// </summary>
        public string IdUsuario { get; set; }

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

        /// <summary>
        /// Convierte la medicion en una linea del CSV.
        /// </summary>
        public override string ToString()
        {
            return Id + "," + IdUsuario + "," + Fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "," +
                   Peso.ToString(CultureInfo.InvariantCulture) + "," +
                   Grasa.ToString(CultureInfo.InvariantCulture) + "," +
                   Musculatura.ToString(CultureInfo.InvariantCulture);
        }
    }
}