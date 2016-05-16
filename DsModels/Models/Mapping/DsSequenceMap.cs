using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsSequenceMap : EntityTypeConfiguration<DsSequence>
    {
        public DsSequenceMap()
        {
            // Primary Key
            this.HasKey(t => t.Type);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Format)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DsSequence");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.DataTime).HasColumnName("DataTime");
            this.Property(t => t.Format).HasColumnName("Format");
            this.Property(t => t.CurrentValue).HasColumnName("CurrentValue");
        }
    }
}
