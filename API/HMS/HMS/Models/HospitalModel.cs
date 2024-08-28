using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class HospitalModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage ="Max length of 100")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string Address { get; set; } = string.Empty;
        public long Phone { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string Website { get; set; } = string.Empty;
        [Required]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string GST { get; set; } = string.Empty;
        [Required]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string Email { get; set; } = string.Empty;

    }
}
