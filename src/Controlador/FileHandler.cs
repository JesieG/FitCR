using System;
using System.Collections.Generic;
using System.IO;

namespace FitCR
{
    // Lee y guarda datos usando archivos. Esta es la base que dio el profe.
    public class FileHandler<T> : IDataHandler<T>
    {
        public List<T> LoadData(string filename)
        {
            if (string.IsNullOrEmpty(filename) || !File.Exists(filename))
            {
                return null;
            }

            var data = new List<T>();
            var lines = File.ReadAllLines(filename);

            for (var i = 1; i < lines.Length; i++)
            {
                var lineElements = lines[i].Split(',');
                var newElement = Activator.CreateInstance(typeof(T), lineElements);
                data.Add((T)newElement);
            }

            return data;
        }

        public bool SaveData(string filename, List<T> data)
        {
            if (string.IsNullOrEmpty(filename) || data == null || data.Count == 0)
            {
                return false;
            }

            // Guarda la primera linea (los titulos) para no perderla.
            var titulos = "";
            if (File.Exists(filename))
            {
                var lineasActuales = File.ReadAllLines(filename);
                if (lineasActuales.Length > 0)
                {
                    titulos = lineasActuales[0];
                }
            }

            var lineasNuevas = new List<string>();
            lineasNuevas.Add(titulos);
            foreach (var element in data)
            {
                lineasNuevas.Add(element.ToString());
            }

            File.WriteAllLines(filename, lineasNuevas);
            return true;
        }
    }
}