using ClaimTrackingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimTrackingSystem.Application.DTOs
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Guid Role { get; set; }
        public UserRole UserRole { get; set; }
    }
}
