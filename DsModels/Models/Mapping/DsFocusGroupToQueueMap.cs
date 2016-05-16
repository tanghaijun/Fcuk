using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFocusGroupToQueueMap : EntityTypeConfiguration<DsFocusGroupToQueue>
    {
        public DsFocusGroupToQueueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FocusGroupID, t.FocusQueueID });

            // Properties
            this.Property(t => t.FocusGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FocusQueueID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsFocusGroupToQueue");
            this.Property(t => t.FocusGroupID).HasColumnName("FocusGroupID");
            this.Property(t => t.FocusQueueID).HasColumnName("FocusQueueID");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
