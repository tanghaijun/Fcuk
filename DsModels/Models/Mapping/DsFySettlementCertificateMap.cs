using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFySettlementCertificateMap : EntityTypeConfiguration<DsFySettlementCertificate>
    {
        public DsFySettlementCertificateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FySettlementID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("DsFySettlementCertificate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FySettlementID).HasColumnName("FySettlementID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
