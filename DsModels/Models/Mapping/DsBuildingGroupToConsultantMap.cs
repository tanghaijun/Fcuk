using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsBuildingGroupToConsultantMap : EntityTypeConfiguration<DsBuildingGroupToConsultant>
    {
        public DsBuildingGroupToConsultantMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BuildingGroupID, t.UserID });

            // Properties
            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsBuildingGroupToConsultant");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.AskPriceDivideCount).HasColumnName("AskPriceDivideCount");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
