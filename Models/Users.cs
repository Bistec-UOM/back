using System.Text.Json.Serialization;

namespace Models
{
    internal class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? NIC { get; set; }
        public string? Role { get; set; }
        public string? Gender { get; set;}
        public string? Address { get; set;}
        public string? Qualifications { get; set;}
        [JsonIgnore]
        public List<Patient_Tele>? TelephoneNumbers { get; set; }
    }
}
