using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Models
{
    public class ViewProjectMeeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public string Note { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
    }
}
