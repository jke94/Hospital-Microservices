namespace Entities.Context
{
    using Entities.Models;
    using Microsoft.EntityFrameworkCore;

    public class RepositoryContext : DbContext, IRepositoryContext
    {
        public RepositoryContext()
        {

        }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) 
            : base (options)
        {

        }

        protected RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<MedicalTreatment> MedicalTreatments { get; set; }
    }
}