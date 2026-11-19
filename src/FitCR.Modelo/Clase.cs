namespace FitCR.Modelo
{
    /// <summary>
    /// Clase que ofrece el gimnasio: yoga, crossfit, zumba, spinning o gimnasio abierto.
    /// </summary>
    public class Clase
    {
        /// <summary>
        /// Crea una clase a partir de los textos de una linea del CSV.
        /// </summary>
        public Clase(string id, string nombre, string tipo, string idEntrenador)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            IdEntrenador = idEntrenador;
        }

        /// <summary>
        /// Identificador de la clase.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Nombre de la clase, con su dia y hora.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Tipo de clase.
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Identificador del entrenador a cargo.
        /// </summary>
        public string IdEntrenador { get; set; }
    }
}