using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class RatingModel
    {
        [Key]
        public int RateId { get; set; }
        public int RecieverId { get; set; }
        public int SenderId { get; set; }
        public string InnovativeID { get; set; }
        public int Rate { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
    }
}
