using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsCostPeriodMap : EntityTypeConfiguration<DsCostPeriod>
    {
        public DsCostPeriodMap()
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

            // Table & Column Mappings
            this.ToTable("DsCostPeriod");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.BusinessType).HasColumnName("BusinessType");
            this.Property(t => t.CostType).HasColumnName("CostType");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CostRatio).HasColumnName("CostRatio");
            this.Property(t => t.FixCost).HasColumnName("FixCost");
        }
    }
}
