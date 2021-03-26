using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimTrackingSystem.Application.DTOs
{
    public class UpdateUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid Role { get; set; }
        public int Age { get; set; }
    }
}
