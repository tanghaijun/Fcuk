using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFocusGroupToSimulateFyMap : EntityTypeConfiguration<DsFocusGroupToSimulateFy>
    {
        public DsFocusGroupToSimulateFyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FocusGroupID, t.FocusSimulateFyID });

            // Properties
            this.Property(t => t.FocusGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FocusSimulateFyID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsFocusGroupToSimulateFy");
            this.Property(t => t.FocusGroupID).HasColumnName("FocusGroupID");
            this.Property(t => t.FocusSimulateFyID).HasColumnName("FocusSimulateFyID");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
