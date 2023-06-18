using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class UserComment
    {
        [Key]
        public int id { get; set; }
        public int TaskId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string UserID { get; set; } = string.Empty;
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
