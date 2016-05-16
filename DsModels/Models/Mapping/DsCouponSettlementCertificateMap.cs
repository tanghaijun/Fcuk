using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsCouponSettlementCertificateMap : EntityTypeConfiguration<DsCouponSettlementCertificate>
    {
        public DsCouponSettlementCertificateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CouponSettlementID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("DsCouponSettlementCertificate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CouponSettlementID).HasColumnName("CouponSettlementID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
