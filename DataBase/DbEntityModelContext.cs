using DataLayer.Mapping;
using DataLayer.Models.ViewModel;
using System.Data.Entity;

namespace DataBase
{
    public partial class DbEntityModelContext : DbContext
    {
        public DbEntityModelContext()
            : base("name=DbEntityModelContext")
        {
        }

        public virtual DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PatientMapping());
        }
    }
}
