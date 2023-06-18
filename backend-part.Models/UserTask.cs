using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class UserTask
    {
        [Key]
        public int id { get; set; }
        public int InnovativeId { get; set; }
        public string TaskName { get; set; } = string.Empty;

        public string DueDate { get; set; } = string.Empty;
        public int Prograss { get; set; }
    }
}
