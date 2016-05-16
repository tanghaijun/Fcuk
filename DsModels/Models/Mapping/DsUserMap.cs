using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsUserMap : EntityTypeConfiguration<DsUser>
    {
        public DsUserMap()
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

            this.Property(t => t.EnterpriseID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PassportID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MobilePhone)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("DsUser");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.EnterpriseID).HasColumnName("EnterpriseID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.PassportID).HasColumnName("PassportID");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsWork).HasColumnName("IsWork");
        }
    }
}
