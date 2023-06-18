using System.ComponentModel.DataAnnotations;

namespace backend_part.MODELS
{
    public class Innovative
    {
        [Required]
        public int? InnovativeId { get; set; }
        [MaxLength(150)]
        public string? InnovativeName { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }

        public string? LeadId { get; set; }

        public string? EvaluatorId { get; set; }

        public DateTime StartDate { get; set; }

    }
}
