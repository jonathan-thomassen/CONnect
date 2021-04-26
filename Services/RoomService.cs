using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONnect.Interfaces;
using CONnect.Models;

namespace CONnect.Services
{
    public class RoomService : SQLService<Room>, ICrudService<Room>
    {
        public RoomService()
        {
            Items = new List<Room>();
        }
        public bool Create(Room item)
        {
            int fisk = 1;
            return true;
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public Room GetFromId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Room item)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetFiltered(string filter, ICrudService<Room>.FilterType filterType)
        {
            throw new NotImplementedException();
        }
    }
}
