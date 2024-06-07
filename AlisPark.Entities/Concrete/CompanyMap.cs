using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class CompanyMap:EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {

            this.ToTable("CompanyUsers");

            this.HasKey(p => p.AdminId);
            this.Property(p => p.AdminId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CompanyAdminPhone).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.CompanyAdminUsername).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.CompanyAdminPassword).HasColumnType("varchar").HasMaxLength(30);
        }
    }
}
