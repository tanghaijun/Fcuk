using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsBuildingHouseMap : EntityTypeConfiguration<DsBuildingHouse>
    {
        public DsBuildingHouseMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingGroupHouseTypeID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupHouseTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingHouseNumberID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingFloorID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingFloorName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingUnitID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingUnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingGroupNewcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FangYuanID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DsBuildingHouse");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.SqmPrice).HasColumnName("SqmPrice");
            this.Property(t => t.BuildingGroupHouseTypeID).HasColumnName("BuildingGroupHouseTypeID");
            this.Property(t => t.BuildingGroupHouseTypeName).HasColumnName("BuildingGroupHouseTypeName");
            this.Property(t => t.BuildingGroupHouseTypeShiCount).HasColumnName("BuildingGroupHouseTypeShiCount");
            this.Property(t => t.BuildingGroupHouseTypeTingCount).HasColumnName("BuildingGroupHouseTypeTingCount");
            this.Property(t => t.BuildingGroupHouseTypeWeiCount).HasColumnName("BuildingGroupHouseTypeWeiCount");
            this.Property(t => t.BuildingGroupHouseTypeChuCount).HasColumnName("BuildingGroupHouseTypeChuCount");
            this.Property(t => t.BuildingGroupHouseTypeArea).HasColumnName("BuildingGroupHouseTypeArea");
            this.Property(t => t.BuildingHouseNumberID).HasColumnName("BuildingHouseNumberID");
            this.Property(t => t.BuildingHouseNumberName).HasColumnName("BuildingHouseNumberName");
            this.Property(t => t.BuildingFloorID).HasColumnName("BuildingFloorID");
            this.Property(t => t.BuildingFloorName).HasColumnName("BuildingFloorName");
            this.Property(t => t.BuildingUnitID).HasColumnName("BuildingUnitID");
            this.Property(t => t.BuildingUnitName).HasColumnName("BuildingUnitName");
            this.Property(t => t.BuildingID).HasColumnName("BuildingID");
            this.Property(t => t.BuildingName).HasColumnName("BuildingName");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.BuildingGroupName).HasColumnName("BuildingGroupName");
            this.Property(t => t.BuildingGroupNewcode).HasColumnName("BuildingGroupNewcode");
            this.Property(t => t.BuildingGroupCityCode).HasColumnName("BuildingGroupCityCode");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
            this.Property(t => t.FangYuanID).HasColumnName("FangYuanID");
        }
    }
}
