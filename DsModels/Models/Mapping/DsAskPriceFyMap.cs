using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsAskPriceFyMap : EntityTypeConfiguration<DsAskPriceFy>
    {
        public DsAskPriceFyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingHouseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingHouseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AskPriceOrderID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsAskPriceFy");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BuildingHouseID).HasColumnName("BuildingHouseID");
            this.Property(t => t.BuildingHouseName).HasColumnName("BuildingHouseName");
            this.Property(t => t.BuildingHouseArea).HasColumnName("BuildingHouseArea");
            this.Property(t => t.BuildingHouseSqmPrice).HasColumnName("BuildingHouseSqmPrice");
            this.Property(t => t.BuildingHouseState).HasColumnName("BuildingHouseState");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PriceType).HasColumnName("PriceType");
            this.Property(t => t.LockInterval).HasColumnName("LockInterval");
            this.Property(t => t.AskPriceOrderID).HasColumnName("AskPriceOrderID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
