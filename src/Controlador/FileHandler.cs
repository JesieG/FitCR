using System;
using System.Collections.Generic;
using System.IO;

namespace FitCR
{
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

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            foreach (var element in data)
            {
                File.AppendAllText(filename, element.ToString() + Environment.NewLine);
            }

            return true;
        }
    }
}