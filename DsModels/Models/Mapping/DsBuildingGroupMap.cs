using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsBuildingGroupMap : EntityTypeConfiguration<DsBuildingGroup>
    {
        public DsBuildingGroupMap()
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

            this.Property(t => t.Newcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.WapUrl)
                .IsRequired()
                .HasMaxLength(500);

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

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsBuildingGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Newcode).HasColumnName("Newcode");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.WapUrl).HasColumnName("WapUrl");
            this.Property(t => t.CityCode).HasColumnName("CityCode");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ContentText).HasColumnName("ContentText");
            this.Property(t => t.ShortTitle).HasColumnName("ShortTitle");
            this.Property(t => t.ShortContentText).HasColumnName("ShortContentText");
            this.Property(t => t.IsShow).HasColumnName("IsShow");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
