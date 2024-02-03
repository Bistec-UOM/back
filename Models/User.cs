using System.Text.Json.Serialization;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? NIC { get; set; }
        public string? Role { get; set; }
        public string? Gender { get; set;}
        public string? Address { get; set;}
        public string? Qualifications { get; set;}

    }
}
