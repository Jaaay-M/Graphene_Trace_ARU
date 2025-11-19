namespace Graphene_Trace.Data
{
    using Microsoft.EntityFrameworkCore;
    public class userdata : DbContext
    {
        public userdata(DbContextOptions<userdata> options) : base(options)
        {
        }
        public DbSet<Graphene_Trace.Models.Patient> Patients { get; set; }
        public DbSet<Graphene_Trace.Models.Doctor> Doctors { get; set; }
        public DbSet<Graphene_Trace.Models.Carer> Carers { get; set; }

    }
}
