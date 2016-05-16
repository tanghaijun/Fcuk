using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFyOrderMap : EntityTypeConfiguration<DsFyOrder>
    {
        public DsFyOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SequenceCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FyID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuyerUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ConsultantUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BoyUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingHouseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingHouseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DynamicCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Source)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DsFyOrder");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.FyID).HasColumnName("FyID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.BuyerUserID).HasColumnName("BuyerUserID");
            this.Property(t => t.ConsultantUserID).HasColumnName("ConsultantUserID");
            this.Property(t => t.BoyUserID).HasColumnName("BoyUserID");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PriceType).HasColumnName("PriceType");
            this.Property(t => t.IsPay).HasColumnName("IsPay");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.IsRefund).HasColumnName("IsRefund");
            this.Property(t => t.RefundTime).HasColumnName("RefundTime");
            this.Property(t => t.IsTrade).HasColumnName("IsTrade");
            this.Property(t => t.TradeTime).HasColumnName("TradeTime");
            this.Property(t => t.LockTime).HasColumnName("LockTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.DeleteTime).HasColumnName("DeleteTime");
            this.Property(t => t.IsSettlement).HasColumnName("IsSettlement");
            this.Property(t => t.SettlementTime).HasColumnName("SettlementTime");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CostType).HasColumnName("CostType");
            this.Property(t => t.CostRatio).HasColumnName("CostRatio");
            this.Property(t => t.FixCost).HasColumnName("FixCost");
            this.Property(t => t.BuildingHouseID).HasColumnName("BuildingHouseID");
            this.Property(t => t.BuildingHouseName).HasColumnName("BuildingHouseName");
            this.Property(t => t.DynamicCode).HasColumnName("DynamicCode");
            this.Property(t => t.DynamicCodeUpdateTime).HasColumnName("DynamicCodeUpdateTime");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.Source).HasColumnName("Source");
        }
    }
}
