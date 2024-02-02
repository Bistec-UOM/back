using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    internal class User_Tele
    {
        public int Id { get; set; }
        public int telephonenumber { get; set; }
        [JsonIgnore]
        public Users? Users { get; set; }
    }
}
