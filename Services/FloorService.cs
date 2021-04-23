using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONnect.Interfaces;
using CONnect.Models;

namespace CONnect.Services
{
    public class FloorService : SQLService<Floor>, ICrudService<Floor>
    {
        public FloorService()
        {
            Items = new List<Floor>();
        }

        public bool Create(Floor item)
        {
            throw new NotImplementedException();
        }

        public List<Floor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Floor GetFromId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Floor item)
        {
            throw new NotImplementedException();
        }

        public List<Floor> GetFiltered(string filter, ICrudService<Floor>.FilterType filterType)
        {
            throw new NotImplementedException();
        }
    }
}
