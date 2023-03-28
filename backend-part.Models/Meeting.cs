using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public string InnovativeId { get; set; }
    }
}
