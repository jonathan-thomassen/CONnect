using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONnect.Interfaces
{
    public interface ISQLService<T>
    {
        string QueryBuilder();
        bool SqlCommand();
        void OpenDB();
        void CloseDB();
        void OnRead();
    }
}
