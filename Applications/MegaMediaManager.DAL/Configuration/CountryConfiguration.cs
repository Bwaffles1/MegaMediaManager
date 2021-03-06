using System.Data.Entity.ModelConfiguration;
using MegaMediaManager.Model;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaMediaManager.DAL.TypeConfiguration
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            this.ToTable("country_r");

            Property(a => a.Code).HasColumnName("code");
            //Property(a => a.Description).HasColumnName("description");

            Property(a => a.DateCreated).HasColumnName("date_created");
            Property(a => a.DateModified).HasColumnName("date_modified");
        }
    }
}
