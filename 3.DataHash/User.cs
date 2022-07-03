using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DataHash
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public override int GetHashCode()=>(FirstName+LastName+MiddleName).GetHashCode();
        
    }
}
