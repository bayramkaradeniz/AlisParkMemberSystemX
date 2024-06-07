using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class WorkerMap : EntityTypeConfiguration<Worker>
    {
        public WorkerMap()
        {
            this.ToTable("Workers");
            this.HasKey(p => p.WorkerId);
            this.Property(p => p.WorkerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.WorkerUserName).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
