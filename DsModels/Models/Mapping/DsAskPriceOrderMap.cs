using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsAskPriceOrderMap : EntityTypeConfiguration<DsAskPriceOrder>
    {
        public DsAskPriceOrderMap()
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

            this.Property(t => t.AskPriceID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuyerUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ConsultantUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ReplyContentText)
                .IsRequired();

            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.IntentionBuildingGroupHouseTypeID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.IntentionBuildingGroupHouseTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IntentionBuildingFloorID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.IntentionBuildingFloorName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IntentionBuildingID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.IntentionBuildingName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IntentionContentText)
                .IsRequired();

            this.Property(t => t.IntentionBuildingHouseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.IntentionBuildingHouseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingHouseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingHouseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FyOrderID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Source)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DsAskPriceOrder");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.AskPriceID).HasColumnName("AskPriceID");
            this.Property(t => t.BuyerUserID).HasColumnName("BuyerUserID");
            this.Property(t => t.ConsultantUserID).HasColumnName("ConsultantUserID");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.IsPay).HasColumnName("IsPay");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.IsReply).HasColumnName("IsReply");
            this.Property(t => t.ReplyTime).HasColumnName("ReplyTime");
            this.Property(t => t.ReplyContentText).HasColumnName("ReplyContentText");
            this.Property(t => t.OverdueTime).HasColumnName("OverdueTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.DeleteTime).HasColumnName("DeleteTime");
            this.Property(t => t.IsSettlement).HasColumnName("IsSettlement");
            this.Property(t => t.SettlementTime).HasColumnName("SettlementTime");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CostType).HasColumnName("CostType");
            this.Property(t => t.CostRatio).HasColumnName("CostRatio");
            this.Property(t => t.FixCost).HasColumnName("FixCost");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.IntentionBuildingGroupHouseTypeID).HasColumnName("IntentionBuildingGroupHouseTypeID");
            this.Property(t => t.IntentionBuildingGroupHouseTypeName).HasColumnName("IntentionBuildingGroupHouseTypeName");
            this.Property(t => t.IntentionBuildingFloorID).HasColumnName("IntentionBuildingFloorID");
            this.Property(t => t.IntentionBuildingFloorName).HasColumnName("IntentionBuildingFloorName");
            this.Property(t => t.IntentionBuildingID).HasColumnName("IntentionBuildingID");
            this.Property(t => t.IntentionBuildingName).HasColumnName("IntentionBuildingName");
            this.Property(t => t.IntentionPayType).HasColumnName("IntentionPayType");
            this.Property(t => t.IntentionContentText).HasColumnName("IntentionContentText");
            this.Property(t => t.IntentionBuildingHouseID).HasColumnName("IntentionBuildingHouseID");
            this.Property(t => t.IntentionBuildingHouseName).HasColumnName("IntentionBuildingHouseName");
            this.Property(t => t.BuildingHouseID).HasColumnName("BuildingHouseID");
            this.Property(t => t.BuildingHouseName).HasColumnName("BuildingHouseName");
            this.Property(t => t.FyOrderID).HasColumnName("FyOrderID");
            this.Property(t => t.Source).HasColumnName("Source");
        }
    }
}
