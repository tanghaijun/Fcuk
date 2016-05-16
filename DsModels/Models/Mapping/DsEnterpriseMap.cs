using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsEnterpriseMap : EntityTypeConfiguration<DsEnterprise>
    {
        public DsEnterpriseMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SequenceCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ZipCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Fax)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.EnterpriseJoinInApplyID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsEnterprise");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CityCode).HasColumnName("CityCode");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.EnterpriseJoinInApplyID).HasColumnName("EnterpriseJoinInApplyID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
