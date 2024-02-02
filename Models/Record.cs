using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Record
    {
        public string ReportID { get; set; } = null!;
        public string FieldName { get; set; } = null!;
        public float Result { get; set; }
        public string Status { get; set; } = null!;
    }
}
