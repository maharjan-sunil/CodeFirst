using DataLayer.Models.ViewModel;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Mapping
{
    public class PatientMapping : EntityTypeConfiguration<Patient>
    {
        public PatientMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(20);
            Property(x => x.Address).IsOptional().HasMaxLength(20);
        }
    }
}