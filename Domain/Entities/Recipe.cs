using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Recipe
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public string Img { get; set; }

        [Required]
        public virtual Category Category { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Ingredients  { get; set; }

        [Required]
        [StringLength(3000)]
        public string Instructions { get; set; }

        [Required]
        public bool Public { get; set; } = false;

        [Required]
        public DateTime? PublicationDate { get; set; }

        [Required]
        public virtual ICollection<Score> Scores { get; set; }
    }
}
