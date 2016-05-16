using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFocusGroupMap : EntityTypeConfiguration<DsFocusGroup>
    {
        public DsFocusGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FocusID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsFocusGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FocusID).HasColumnName("FocusID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
            this.Property(t => t.SimulateStartTime).HasColumnName("SimulateStartTime");
            this.Property(t => t.SimulateEndTime).HasColumnName("SimulateEndTime");
        }
    }
}
