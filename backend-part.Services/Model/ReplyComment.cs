using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class ReplyComment
    {
        [Required]
       public int TaskId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public int UserID { get; set; }
        [Required]
        public int ParentId { get; set; }
    }
}
