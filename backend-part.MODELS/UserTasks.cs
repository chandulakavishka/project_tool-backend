using System.ComponentModel.DataAnnotations;

namespace backend_part.MODELS
{
    public class UserTasks
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [MaxLength(150)]
        public string? TaskName { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }

        public CurrentProgrress? CurrentProgress { get; set; }

        public int InnovativeId { get; set; }

        public Innovative? Innovative { get; set; }
    }
}
