using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFocusQueueMap : EntityTypeConfiguration<DsFocusQueue>
    {
        public DsFocusQueueMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FocusID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SequenceCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CouponOrderID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FyOrderID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SimulateFyOrderID)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsFocusQueue");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.FocusID).HasColumnName("FocusID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.CouponOrderID).HasColumnName("CouponOrderID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.FyOrderID).HasColumnName("FyOrderID");
            this.Property(t => t.SimulateFyOrderID).HasColumnName("SimulateFyOrderID");
        }
    }
}
