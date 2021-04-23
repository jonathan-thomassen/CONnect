using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONnect.Interfaces
{
    public interface ICrudService<T>
    {
        enum FilterType
        {
            Name,
            Type,
            StartTime,
            EndTime,
            Status,
            Room,
            Theme
        }

        bool Create(T item);
        List<T> GetAll();
        T GetFromId(int id);
        bool Delete(int id);
        bool Update(T item);
        List<T> GetFiltered(string filter, FilterType filterType);
    }
}