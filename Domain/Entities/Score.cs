using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Score
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id {get; set;}

        [Required]
        [Range(0, 5)]
        public int? Value { get; set;} = 0;

        [Required]
        public DateTime? PublicationDate { get; set; } = DateTime.Now;

    }
}
