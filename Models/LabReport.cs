using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LabReport
    {
        public string ReportID { get; set; } = null!;
        public string PrescriptID { get; set; } = null!;
        public TimeOnly Time {  get; set; }
        public DateOnly Date { get; set; }
        public string TestName { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}
