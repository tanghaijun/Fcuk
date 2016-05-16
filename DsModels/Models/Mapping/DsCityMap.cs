using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsCityMap : EntityTypeConfiguration<DsCity>
    {
        public DsCityMap()
        {
            // Primary Key
            this.HasKey(t => t.Code);

            // Properties
            this.Property(t => t.Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Abbr)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("DsCity");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Abbr).HasColumnName("Abbr");
            this.Property(t => t.IsOpen).HasColumnName("IsOpen");
        }
    }
}
