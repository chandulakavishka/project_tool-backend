using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services.Model
{
    public class GetComment
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public int UserID { get; set; }
        [Required]
        public int ParentId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
