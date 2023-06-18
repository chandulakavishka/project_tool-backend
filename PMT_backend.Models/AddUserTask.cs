using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT_backend.Models
{
    public class AddUserTask
    {
       [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int TaskId { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
