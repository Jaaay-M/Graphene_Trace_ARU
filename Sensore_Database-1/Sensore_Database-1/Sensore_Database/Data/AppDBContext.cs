namespace Sensore_Database.Data
{
    using Microsoft.EntityFrameworkCore;
    using Sensore_Database.Models;

    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
