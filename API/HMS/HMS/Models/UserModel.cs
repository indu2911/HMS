namespace HMS.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public long Phone { get; set; }
        public int RoleId { get; set; }
        public int HospitalId { get; set; }
        public string Email { get; set; } = string.Empty;
        public int Createdby { get; set; }

    }
}
