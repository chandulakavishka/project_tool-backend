using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class SharePoint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SharePoitntID { get; set;}
        public int Point { get; set;}
        public int RecieverId { get; set;}
        public int SenderId { get; set;}
        public string? ProjectId { get; set; }
    }
}
