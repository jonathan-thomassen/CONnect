using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONnect.Interfaces;
using CONnect.Models;

namespace CONnect.Services
{
    public class SpeakerService : SQLService<Speaker>, ICrudService<Speaker>
    {
        public SpeakerService()
        {
            Items = new List<Speaker>();
        }

        public bool Create(Speaker item)
        {
            throw new NotImplementedException();
        }

        public List<Speaker> GetAll()
        {
            throw new NotImplementedException();
        }

        public Speaker GetFromId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Speaker item)
        {
            throw new NotImplementedException();
        }

        public List<Speaker> GetFiltered(string filter, ICrudService<Speaker>.FilterType filterType)
        {
            throw new NotImplementedException();
        }
    }
}
