using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class Innovative
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string InnovativeName { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Prograss { get; set; }
        public DateTime? StartDate { get; set; } 

    }
}
