using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Comment Response { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(250)]
        public string Text { get; set; }
    }
}
