using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONnect.Interfaces;
using CONnect.Models;

namespace CONnect.Services
{
    public class ConferenceService : SQLService<Conference>, ICrudService<Conference>
    {
        public ConferenceService()
        {
            Items = new List<Conference>();
        }

        public bool Create(Conference item)
        {
            throw new NotImplementedException();
        }

        public List<Conference> GetAll()
        {
            throw new NotImplementedException();
        }

        public Conference GetFromId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Conference item)
        {
            throw new NotImplementedException();
        }

        public List<Conference> GetFiltered(string filter, ICrudService<Conference>.FilterType filterType)
        {
            throw new NotImplementedException();
        }
    }
}
