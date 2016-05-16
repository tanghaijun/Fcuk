using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsMessageMap : EntityTypeConfiguration<DsMessage>
    {
        public DsMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FromUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ToUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ContentText)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DsMessage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.FromUserID).HasColumnName("FromUserID");
            this.Property(t => t.ToUserID).HasColumnName("ToUserID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ContentText).HasColumnName("ContentText");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
