using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services.Model
{
    public class EditTask
    {
        [Required]
        public int id { get; set; }
        // public string TaskName { get; set; } = string.Empty;
        public string DueDate { get; set; } = string.Empty;
        //public int Prograss { get; set; }
    }
}
