﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    internal class Patient
    {
        public int Id { get; set; }
        public string? NIC { get; set; }
        public string? Name { get; set; }
        public int DOB { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        [JsonIgnore]
        public List<User_Tele>? TelephoneNumbers { get; set; }
    }
}
