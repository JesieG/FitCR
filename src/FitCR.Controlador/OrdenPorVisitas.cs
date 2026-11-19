using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Dice como ordenar los resumenes de visitas: de mayor a menor cantidad. Si empatan, por nombre.
    /// </summary>
    public class OrdenPorVisitas : IComparer<VisitasPorUsuario>
    {
        /// <summary>
        /// Compara dos resumenes. Un numero negativo significa que el primero va antes.
        /// </summary>
        public int Compare(VisitasPorUsuario? primero, VisitasPorUsuario? segundo)
        {
            if (primero == null || segundo == null)
            {
                return 0;
            }

            var comparacion = segundo.Cantidad.CompareTo(primero.Cantidad);
            if (comparacion != 0)
            {
                return comparacion;
            }

            return string.Compare(primero.Nombre, segundo.Nombre, StringComparison.OrdinalIgnoreCase);
        }
    }
}