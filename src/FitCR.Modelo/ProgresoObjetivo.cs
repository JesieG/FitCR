namespace FitCR.Modelo
{
    /// <summary>
    /// Avance de un usuario hacia una de sus metas dentro de un rango de fechas.
    /// </summary>
    public class ProgresoObjetivo
    {
        /// <summary>
        /// Crea el avance con el nombre de la meta, su objetivo, los valores del rango y el estado.
        /// </summary>
        public ProgresoObjetivo(string nombre, double objetivo, double? valorInicial, double? valorFinal, string estado)
        {
            Nombre = nombre;
            Objetivo = objetivo;
            ValorInicial = valorInicial;
            ValorFinal = valorFinal;
            Estado = estado;
        }

        /// <summary>
        /// Nombre de la meta.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Valor que el usuario quiere alcanzar.
        /// </summary>
        public double Objetivo { get; set; }

        /// <summary>
        /// Valor al inicio del rango. Es null si no hay datos.
        /// </summary>
        public double? ValorInicial { get; set; }

        /// <summary>
        /// Valor al final del rango. Es null si no hay datos.
        /// </summary>
        public double? ValorFinal { get; set; }

        /// <summary>
        /// Estado de la meta: cumplida, en progreso o sin mejora.
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Cuanto cambio el valor: el final menos el inicial. Es null si falta alguno de los dos.
        /// </summary>
        public double? Cambio
        {
            get
            {
                if (ValorInicial == null || ValorFinal == null)
                {
                    return null;
                }

                return ValorFinal - ValorInicial;
            }
        }
    }
}