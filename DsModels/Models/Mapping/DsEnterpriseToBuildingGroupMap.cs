using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsEnterpriseToBuildingGroupMap : EntityTypeConfiguration<DsEnterpriseToBuildingGroup>
    {
        public DsEnterpriseToBuildingGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EnterpriseID, t.BuildingGroupID });

            // Properties
            this.Property(t => t.EnterpriseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsEnterpriseToBuildingGroup");
            this.Property(t => t.EnterpriseID).HasColumnName("EnterpriseID");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
        }
    }
}
