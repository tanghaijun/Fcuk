using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsLogMap : EntityTypeConfiguration<DsLog>
    {
        public DsLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Data)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DsLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
