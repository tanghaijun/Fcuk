using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsEnterpriseBankCardMap : EntityTypeConfiguration<DsEnterpriseBankCard>
    {
        public DsEnterpriseBankCardMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CardOwner)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardBank)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EnterpriseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsEnterpriseBankCard");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CardOwner).HasColumnName("CardOwner");
            this.Property(t => t.CardNumber).HasColumnName("CardNumber");
            this.Property(t => t.CardBank).HasColumnName("CardBank");
            this.Property(t => t.CardCityCode).HasColumnName("CardCityCode");
            this.Property(t => t.EnterpriseID).HasColumnName("EnterpriseID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
        }
    }
}
