using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class HospitalModel
    {
        [Required]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Min length of 3")]
        [MaxLength(100, ErrorMessage ="Max length of 100")]
        public string Name { get; set; } = string.Empty;

        [MinLength(3, ErrorMessage = "Min length of 3")]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string Address { get; set; } = string.Empty;

       
        [Required]
        public long Phone { get; set; }
        
        [Required]
        [MinLength(6, ErrorMessage = "Min length of 6")]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string Website { get; set; } = string.Empty;

       
        [Required]
        [MinLength(3, ErrorMessage = "Min length of 3")]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string GST { get; set; } = string.Empty;

        [Required]
        [MinLength(3, ErrorMessage = "Min length of 3")]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

    }
}
