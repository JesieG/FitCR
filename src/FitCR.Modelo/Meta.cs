using System.Globalization;

namespace FitCR.Modelo
{
    /// <summary>
    /// Metas de un usuario: porcentaje de grasa, porcentaje de musculatura y visitas por mes.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Crea una meta a partir de los textos de una linea del CSV.
        /// </summary>
        public Meta(string id, string idUsuario, string grasaObjetivo, string musculaturaObjetivo, string visitasPorMes)
        {
            Id = id;
            IdUsuario = idUsuario;
            GrasaObjetivo = double.Parse(grasaObjetivo, CultureInfo.InvariantCulture);
            MusculaturaObjetivo = double.Parse(musculaturaObjetivo, CultureInfo.InvariantCulture);
            VisitasPorMes = int.Parse(visitasPorMes);
        }

        /// <summary>
        /// Identificador de la meta.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identificador del usuario dueno de la meta.
        /// </summary>
        public string IdUsuario { get; set; }

        /// <summary>
        /// Porcentaje de grasa que el usuario quiere alcanzar o bajar.
        /// </summary>
        public double GrasaObjetivo { get; set; }

        /// <summary>
        /// Porcentaje de musculatura que el usuario quiere alcanzar o superar.
        /// </summary>
        public double MusculaturaObjetivo { get; set; }

        /// <summary>
        /// Cantidad de visitas al gimnasio que el usuario quiere hacer por mes.
        /// </summary>
        public int VisitasPorMes { get; set; }
    }
}