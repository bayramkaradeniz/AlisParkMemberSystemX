using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class LogEntryMap: EntityTypeConfiguration<LogEntry>
    {
        public LogEntryMap()
        {
            this.ToTable("LogEntries");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
