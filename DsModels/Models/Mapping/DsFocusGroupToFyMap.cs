using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFocusGroupToFyMap : EntityTypeConfiguration<DsFocusGroupToFy>
    {
        public DsFocusGroupToFyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FocusGroupID, t.FocusFyID });

            // Properties
            this.Property(t => t.FocusGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FocusFyID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsFocusGroupToFy");
            this.Property(t => t.FocusGroupID).HasColumnName("FocusGroupID");
            this.Property(t => t.FocusFyID).HasColumnName("FocusFyID");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
