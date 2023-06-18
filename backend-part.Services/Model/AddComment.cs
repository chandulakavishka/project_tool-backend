using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services.Model
{
    public class AddComment
    {
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public string UserID { get; set; } = string.Empty;
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; internal set; }
    }
}
