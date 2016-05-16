using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsBuildingPhotoMap : EntityTypeConfiguration<DsBuildingPhoto>
    {
        public DsBuildingPhotoMap()
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

            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsBuildingPhoto");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BuildingID).HasColumnName("BuildingID");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
