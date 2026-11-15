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
        /// Lee un CSV y crea un objeto por cada linea. Devuelve una lista vacia si el archivo no existe.
        /// </summary>
        public List<T> LoadData(string filename)
        {
            var datos = new List<T>();

            if (string.IsNullOrEmpty(filename) || !File.Exists(filename))
            {
                return datos;
            }

            var lineas = File.ReadAllLines(filename);

            // Empieza en 1 para saltarse la linea de titulos.
            for (var i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }

                var elementos = lineas[i].Split(',');
                var nuevoElemento = Activator.CreateInstance(typeof(T), elementos);
                datos.Add((T)nuevoElemento!);
            }

            return datos;
        }

        /// <summary>
        /// Guarda la lista en el CSV, conservando la linea de titulos.
        /// </summary>
        public bool SaveData(string filename, List<T> data)
        {
            if (string.IsNullOrEmpty(filename) || data == null || data.Count == 0)
            {
                return false;
            }

            // Guarda la primera linea (los titulos) para no perderla.
            var titulos = string.Empty;
            if (File.Exists(filename))
            {
                var lineasActuales = File.ReadAllLines(filename);
                if (lineasActuales.Length > 0)
                {
                    titulos = lineasActuales[0];
                }
            }

            var lineasNuevas = new List<string> { titulos };
            foreach (var elemento in data)
            {
                lineasNuevas.Add(elemento?.ToString() ?? string.Empty);
            }

            File.WriteAllLines(filename, lineasNuevas);
            return true;
        }
    }
}