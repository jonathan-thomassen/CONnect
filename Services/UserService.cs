using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONnect.Interfaces;
using CONnect.Models;

namespace CONnect.Services
{
    public class UserService : SQLService<User>, ICrudService<User>
    {
        public UserService()
        {
            Items = new List<User>();
        }

        public bool Create(User item)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetFromId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User item)
        {
            throw new NotImplementedException();
        }

        public List<User> GetFiltered(string filter, ICrudService<User>.FilterType filterType)
        {
            throw new NotImplementedException();
        }
    }
}
