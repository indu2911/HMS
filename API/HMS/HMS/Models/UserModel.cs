using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class UserModel
    {
        [Required]
        public int Id { get; set; }


        [Required]

        [MinLength(3, ErrorMessage = "Min length of 3")]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string Name { get; set; } = string.Empty;


        [Required]
        [MinLength(1,ErrorMessage ="Min length of 1")]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MinLength(8, ErrorMessage = "Min length of 8")]
        [MaxLength(20, ErrorMessage = "Max length of 20")]
        public string Password { get; set; } = string.Empty;

        [Required]
        public long Phone { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public int HospitalId { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Min length of 10")]
        [MaxLength(100, ErrorMessage = "Max length of 100")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public int Createdby { get; set; }

    }
}
