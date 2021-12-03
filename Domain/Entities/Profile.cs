using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Profile
    {
        [ForeignKey("User")]
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual User User { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        public DateTime? Birthday { get; set; } = DateTime.MinValue;

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
