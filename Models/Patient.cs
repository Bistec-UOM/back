﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? NIC { get; set; }
        public string? Name { get; set; }
        public int DOB { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }

    }
}
