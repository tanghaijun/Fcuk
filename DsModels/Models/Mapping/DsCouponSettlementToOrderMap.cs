using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsCouponSettlementToOrderMap : EntityTypeConfiguration<DsCouponSettlementToOrder>
    {
        public DsCouponSettlementToOrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CouponSettlementID, t.CouponOrderID });

            // Properties
            this.Property(t => t.CouponSettlementID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CouponOrderID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsCouponSettlementToOrder");
            this.Property(t => t.CouponSettlementID).HasColumnName("CouponSettlementID");
            this.Property(t => t.CouponOrderID).HasColumnName("CouponOrderID");
        }
    }
}
