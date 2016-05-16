using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsCouponPayMap : EntityTypeConfiguration<DsCouponPay>
    {
        public DsCouponPayMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CouponOrderID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PayID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayData)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DsCouponPay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CouponOrderID).HasColumnName("CouponOrderID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.PayID).HasColumnName("PayID");
            this.Property(t => t.PayData).HasColumnName("PayData");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
