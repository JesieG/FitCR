using System.Reflection;
using FitCR.Controlador.Abstracciones;

namespace FitCR.Controlador
{
    /// <summary>
    /// Lee y guarda datos usando archivos CSV.
    /// </summary>
    /// <typeparam name="T">Tipo de dato que se lee o se guarda.</typeparam>
    public class FileHandler<T> : IDataHandler<T>
    {
        /// <summary>
        /// Lee un CSV y crea un objeto por cada linea.
        /// </summary>
        /// <exception cref="FileNotFoundException">Si el archivo no existe.</exception>
        /// <exception cref="InvalidDataException">Si alguna linea no tiene el formato esperado.</exception>
        public List<T> LoadData(string filename)
        {
            if (string.IsNullOrEmpty(filename) || !File.Exists(filename))
            {
                throw new FileNotFoundException(
                    $"No se encontro el archivo {Path.GetFileName(filename)}. Revise que la carpeta Files este junto a la carpeta src.",
                    filename);
            }

            var datos = new List<T>();
            var lineas = File.ReadAllLines(filename);

            // Empieza en 1 para saltarse la linea de titulos.
            for (var i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }

                datos.Add(CrearElemento(lineas[i], filename, i + 1));
            }

            return datos;
        }

        /// <summary>
        /// Guarda la lista en el CSV, conservando la linea de titulos.
        /// </summary>
        /// <returns>True si se guardo, false si no hay nada que guardar o el archivo no se pudo escribir.</returns>
        public bool SaveData(string filename, List<T> data)
        {
            if (string.IsNullOrEmpty(filename) || data == null || data.Count == 0)
            {
                return false;
            }

            try
            {
                var lineasNuevas = new List<string> { LeerTitulos(filename) };

                foreach (var elemento in data)
                {
                    lineasNuevas.Add(elemento?.ToString() ?? string.Empty);
                }

                File.WriteAllLines(filename, lineasNuevas);
                return true;
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                // El archivo esta abierto en otro programa o no se puede escribir.
                return false;
            }
        }

        // Crea el objeto de una linea. Si los datos no calzan con la clase, avisa cual linea tiene el problema.
        private static T CrearElemento(string linea, string filename, int numeroDeLinea)
        {
            try
            {
                var elementos = linea.Split(',');
                return (T)Activator.CreateInstance(typeof(T), elementos)!;
            }
            catch (Exception ex) when (ex is MissingMethodException || ex is TargetInvocationException)
            {
                throw new InvalidDataException(
                    $"El archivo {Path.GetFileName(filename)} tiene un dato incorrecto en la linea {numeroDeLinea}.",
                    ex);
            }
        }

        // Devuelve la primera linea del archivo actual (los titulos). Si no hay archivo, devuelve texto vacio.
        private static string LeerTitulos(string filename)
        {
            if (!File.Exists(filename))
            {
                return string.Empty;
            }

            var lineas = File.ReadAllLines(filename);

            if (lineas.Length == 0)
            {
                return string.Empty;
            }

            return lineas[0];
        }
    }
}