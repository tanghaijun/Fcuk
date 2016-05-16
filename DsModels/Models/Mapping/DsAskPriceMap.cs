using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsAskPriceMap : EntityTypeConfiguration<DsAskPrice>
    {
        public DsAskPriceMap()
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

            // Table & Column Mappings
            this.ToTable("DsAskPrice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ContentText).HasColumnName("ContentText");
            this.Property(t => t.ShortTitle).HasColumnName("ShortTitle");
            this.Property(t => t.ShortContentText).HasColumnName("ShortContentText");
            this.Property(t => t.IsSupport).HasColumnName("IsSupport");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.DivideType).HasColumnName("DivideType");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
