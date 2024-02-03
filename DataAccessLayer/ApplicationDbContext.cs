using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<LabReport> labReports { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Patient_Tele> patient_Teles { get; set; }
        public DbSet<Record> records { get; set; }
        public DbSet<ReportFileds> ReportFileds { get; set; }
        public DbSet<Test> tests { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<User_Tele> user_teles { get; set;}

    }
     
}
