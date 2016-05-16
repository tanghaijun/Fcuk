using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsBuildingHouseNumberMap : EntityTypeConfiguration<DsBuildingHouseNumber>
    {
        public DsBuildingHouseNumberMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingUnitID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingUnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BuildingGroupHouseTypeID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupHouseTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsBuildingHouseNumber");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BuildingUnitID).HasColumnName("BuildingUnitID");
            this.Property(t => t.BuildingUnitName).HasColumnName("BuildingUnitName");
            this.Property(t => t.BuildingGroupHouseTypeID).HasColumnName("BuildingGroupHouseTypeID");
            this.Property(t => t.BuildingGroupHouseTypeName).HasColumnName("BuildingGroupHouseTypeName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
