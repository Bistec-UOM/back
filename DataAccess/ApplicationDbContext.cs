using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<LabReport> labReports { get; set; } = null!;
        public DbSet<Patient> patients { get; set; } = null!;
        public DbSet<Patient_Tele> patient_teles { get; set; } = null!;
        public DbSet<Record> records { get; set; } = null!;
        public DbSet<ReportFileds> reportFileds { get; set; } = null!;
        public DbSet<Test> tests { get; set; } = null!;
        public DbSet<User> users { get; set; } = null!;
        public DbSet<User_Tele> user_Teles { get; set; } = null!;



    }
}
