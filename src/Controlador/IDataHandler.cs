using System.Collections.Generic;

namespace FitCR
{
    public interface IDataHandler<T>
    {
        List<T> LoadData(string filename);
        bool SaveData(string filename, List<T> data);
    }
}