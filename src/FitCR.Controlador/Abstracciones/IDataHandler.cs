namespace FitCR.Controlador.Abstracciones
{
    /// <summary>
    /// Contrato para las clases que leen y guardan datos.
    /// </summary>
    /// <typeparam name="T">Tipo de dato que se lee o se guarda.</typeparam>
    public interface IDataHandler<T>
    {
        /// <summary>
        /// Lee los datos del archivo indicado.
        /// </summary>
        /// <param name="filename">Ruta del archivo.</param>
        /// <returns>La lista de datos leidos.</returns>
        List<T> LoadData(string filename);

        /// <summary>
        /// Guarda los datos en el archivo indicado.
        /// </summary>
        /// <param name="filename">Ruta del archivo.</param>
        /// <param name="data">Datos que se van a guardar.</param>
        /// <returns>True si se guardo bien, false si no.</returns>
        bool SaveData(string filename, List<T> data);
    }
}