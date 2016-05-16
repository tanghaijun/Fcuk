using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsAskPriceSettlementToOrderMap : EntityTypeConfiguration<DsAskPriceSettlementToOrder>
    {
        public DsAskPriceSettlementToOrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AskPriceSettlementID, t.AskPriceOrderID });

            // Properties
            this.Property(t => t.AskPriceSettlementID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.AskPriceOrderID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsAskPriceSettlementToOrder");
            this.Property(t => t.AskPriceSettlementID).HasColumnName("AskPriceSettlementID");
            this.Property(t => t.AskPriceOrderID).HasColumnName("AskPriceOrderID");
        }
    }
}
