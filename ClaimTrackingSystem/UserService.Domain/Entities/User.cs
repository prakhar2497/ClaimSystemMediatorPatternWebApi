using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClaimTrackingSystem.Domain.Entities
{
    [Table("User", Schema = "dbo")]
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        [ForeignKey(nameof(UserRole))]
        public Guid Role { get; set; }
        public UserRole UserRole{ get; set; }
        
    }
}
