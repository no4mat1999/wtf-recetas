using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(25)]
        public string Username { get; set; }
        
        [Required]
        [StringLength(150)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [Range(0,1)]
        public bool EmailValidated { get; set; } = false;

        [Required]
        [Range(0,1)]
        public bool Active { get; set; } = true;

        public virtual Profile Profile { get; set; }

    }
}
