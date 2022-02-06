using InformationModels.Models;
using System;

namespace InformationModels.Dtos
{
    public class UserLogDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public DateTime LoginDate { get; set; }
    }
}
