using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string InnovativeName { get; set; }
        public string Status { get; set; }
        public int Prograss { get; set; }
        public DateTime StartDate { get; set; } 

    }
}
