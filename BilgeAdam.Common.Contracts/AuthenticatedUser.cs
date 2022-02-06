using InformationModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common.Contracts
{
    public static class AuthenticatedUser
    {
        public static string UserName { get; set; }
        public static string Email { get; set; }
        public static UserRole UserRole { get; set; }
    }
}
