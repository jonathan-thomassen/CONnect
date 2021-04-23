using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONnect.Services
{
    public class SQLService<T>
    {
        internal List<T> Items;

        internal string QueryBuilder();
        public bool SqlCommand();
        private void openDB();
        private void closeDB();
        internal void OnRead();
    }
}