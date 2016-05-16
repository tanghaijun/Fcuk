using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFySettlementToOrderMap : EntityTypeConfiguration<DsFySettlementToOrder>
    {
        public DsFySettlementToOrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FySettlementID, t.FyOrderID });

            // Properties
            this.Property(t => t.FySettlementID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FyOrderID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsFySettlementToOrder");
            this.Property(t => t.FySettlementID).HasColumnName("FySettlementID");
            this.Property(t => t.FyOrderID).HasColumnName("FyOrderID");
        }
    }
}
