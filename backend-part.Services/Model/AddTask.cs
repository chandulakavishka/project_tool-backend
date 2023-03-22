using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services.Model
{
    public class AddTask
    {
        [Required]
        public int InnovativeId { get; set; }
        [Required]
        public string TaskName { get; set; } = string.Empty;
        [Required]
        public DateTime DueDate { get; set; }
    }
}
