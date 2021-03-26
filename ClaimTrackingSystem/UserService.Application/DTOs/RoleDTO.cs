using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimTrackingSystem.Application.DTOs
{
    public class RoleDTO
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }
        public string Function { get; set; }
    }
}
