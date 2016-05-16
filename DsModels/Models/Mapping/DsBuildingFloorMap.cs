using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsBuildingFloorMap : EntityTypeConfiguration<DsBuildingFloor>
    {
        public DsBuildingFloorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.LouCengID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DsBuildingFloor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BuildingID).HasColumnName("BuildingID");
            this.Property(t => t.BuildingName).HasColumnName("BuildingName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
            this.Property(t => t.LouCengID).HasColumnName("LouCengID");
        }
    }
}
