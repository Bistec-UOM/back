using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class User_Tele
    {
        [Key]
        public int Id { get; set; }
        public int telephonenumber { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User? user { get; set; }
        //public List<User>? users { get; set; }
    }
}
