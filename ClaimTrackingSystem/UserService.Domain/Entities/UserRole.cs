using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClaimTrackingSystem.Domain.Entities
{
    [Table("Role", Schema = "dbo")]
    public class UserRole
    {
        [Key]
        public Guid ID { get; set; }
        public string Role { get; set; }
        public string Function { get; set; }
    }
}
