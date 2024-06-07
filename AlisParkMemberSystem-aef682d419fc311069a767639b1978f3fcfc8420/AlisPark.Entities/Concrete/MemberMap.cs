using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class MemberMap:EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            this.ToTable("Member");
            this.HasKey(p => p.MemberId);
            this.Property(p => p.MemberId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.MemberName).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.MemberSurname).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.MemberPhone).HasColumnType("varchar").HasMaxLength(20);
        }
    }
}
