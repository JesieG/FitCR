namespace FitCR.Modelo
{
    /// <summary>
    /// Cantidad de visitas que tuvo un usuario dentro de un rango de fechas.
    /// </summary>
    public class VisitasPorUsuario
    {
        /// <summary>
        /// Crea el resumen con el nombre del usuario y su cantidad de visitas.
        /// </summary>
        public VisitasPorUsuario(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Cantidad de visitas en el rango de fechas.
        /// </summary>
        public int Cantidad { get; set; }
    }
}