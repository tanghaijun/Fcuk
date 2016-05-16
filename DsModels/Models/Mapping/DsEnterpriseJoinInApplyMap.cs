using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsEnterpriseJoinInApplyMap : EntityTypeConfiguration<DsEnterpriseJoinInApply>
    {
        public DsEnterpriseJoinInApplyMap()
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

            this.Property(t => t.Data)
                .IsRequired();

            this.Property(t => t.Remark)
                .IsRequired();

            this.Property(t => t.ApplyUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.EnterpriseName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("DsEnterpriseJoinInApply");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.ApplyUserID).HasColumnName("ApplyUserID");
            this.Property(t => t.EnterpriseName).HasColumnName("EnterpriseName");
            this.Property(t => t.EnterpriseCityCode).HasColumnName("EnterpriseCityCode");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
