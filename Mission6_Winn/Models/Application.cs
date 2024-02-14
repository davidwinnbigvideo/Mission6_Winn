using System.ComponentModel.DataAnnotations;

namespace Mission6_Winn.Models
{
    public class Application
    {
        [Key]
        public int ApplicationKey { get; set; } 
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public string? Edited { get; set; }
        public string? Lent_to { get; set; }
        public string? Notes { get; set; }
    }
}
