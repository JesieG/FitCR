namespace FitCR.Modelo
{
    /// <summary>
    /// Resumen de un ejercicio en un rango de fechas: el primer peso, el ultimo y cuanto subio.
    /// </summary>
    public class AumentoPorEjercicio
    {
        /// <summary>
        /// Crea el resumen con el nombre del ejercicio y sus pesos.
        /// </summary>
        public AumentoPorEjercicio(string ejercicio, double pesoInicial, double pesoFinal)
        {
            Ejercicio = ejercicio;
            PesoInicial = pesoInicial;
            PesoFinal = pesoFinal;
        }

        /// <summary>
        /// Nombre del ejercicio.
        /// </summary>
        public string Ejercicio { get; set; }

        /// <summary>
        /// Primer peso registrado dentro del rango de fechas.
        /// </summary>
        public double PesoInicial { get; set; }

        /// <summary>
        /// Ultimo peso registrado dentro del rango de fechas.
        /// </summary>
        public double PesoFinal { get; set; }

        /// <summary>
        /// Cuanto subio el peso: el final menos el inicial. Si bajo, da negativo.
        /// </summary>
        public double Aumento => PesoFinal - PesoInicial;
    }
}