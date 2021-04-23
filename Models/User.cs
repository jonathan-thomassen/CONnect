using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONnect.Models
{
    enum UserTypes
    {
        
    }

    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string E-Mail { get; set; }
        public string Password { get; set; }
        public UserTypes Type { get; set; }
        public List<string> Preference { get; set; }
    }
}
