using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFyFollowMap : EntityTypeConfiguration<DsFyFollow>
    {
        public DsFyFollowMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FyOrderID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BoyUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Remark)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DsFyFollow");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FyOrderID).HasColumnName("FyOrderID");
            this.Property(t => t.BoyUserID).HasColumnName("BoyUserID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
