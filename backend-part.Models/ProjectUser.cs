using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class ProjectUser
    {
        [Key]
        public int Id { get; set; }
        public int projectId { get; set; }
        public int UserId { get; set; }
    }
}
