using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsCouponMap : EntityTypeConfiguration<DsCoupon>
    {
        public DsCouponMap()
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

            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupNewcode)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Condition)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ContentText)
                .IsRequired();

            this.Property(t => t.ShortTitle)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ShortContentText)
                .IsRequired();

            this.Property(t => t.EnterpriseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupHouseTypeID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupHouseTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsCoupon");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.BuildingGroupNewcode).HasColumnName("BuildingGroupNewcode");
            this.Property(t => t.Condition).HasColumnName("Condition");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ContentText).HasColumnName("ContentText");
            this.Property(t => t.ShortTitle).HasColumnName("ShortTitle");
            this.Property(t => t.ShortContentText).HasColumnName("ShortContentText");
            this.Property(t => t.ShowPrice).HasColumnName("ShowPrice");
            this.Property(t => t.PayPrice).HasColumnName("PayPrice");
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity");
            this.Property(t => t.PayQuantity).HasColumnName("PayQuantity");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.EnterpriseID).HasColumnName("EnterpriseID");
            this.Property(t => t.BuildingGroupHouseTypeID).HasColumnName("BuildingGroupHouseTypeID");
            this.Property(t => t.BuildingGroupHouseTypeName).HasColumnName("BuildingGroupHouseTypeName");
            this.Property(t => t.BuildingID).HasColumnName("BuildingID");
            this.Property(t => t.BuildingName).HasColumnName("BuildingName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
