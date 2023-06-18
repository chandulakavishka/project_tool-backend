using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT_backend.Services.Model
{
    public class AddTask
    {
        [Required]
        public int InnovativeId { get; set; }
        [Required]
        public string TaskName { get; set; } = string.Empty;
        [Required]
        public string DueDate { get; set; } = string.Empty;
        [Required]
        public int Prograss { get; set; }
    }
}
