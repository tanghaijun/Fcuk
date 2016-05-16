using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsBuildingGroupHouseTypeMap : EntityTypeConfiguration<DsBuildingGroupHouseType>
    {
        public DsBuildingGroupHouseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingGroupNewcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HuXingID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsBuildingGroupHouseType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.BuildingGroupName).HasColumnName("BuildingGroupName");
            this.Property(t => t.BuildingGroupNewcode).HasColumnName("BuildingGroupNewcode");
            this.Property(t => t.BuildingGroupCityCode).HasColumnName("BuildingGroupCityCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ShiCount).HasColumnName("ShiCount");
            this.Property(t => t.TingCount).HasColumnName("TingCount");
            this.Property(t => t.WeiCount).HasColumnName("WeiCount");
            this.Property(t => t.ChuCount).HasColumnName("ChuCount");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.HuXingID).HasColumnName("HuXingID");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
