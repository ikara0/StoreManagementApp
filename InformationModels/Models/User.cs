using InformationModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationModels
{
    public class User
    {
        
        public string Name { get; set; }   
        public string Email { get; set; }
        public string Password { get; set; }   
        public UserRole UserRole { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Email}";
        }
    }
}
