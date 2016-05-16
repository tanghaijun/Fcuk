using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFyPayMap : EntityTypeConfiguration<DsFyPay>
    {
        public DsFyPayMap()
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

            this.Property(t => t.PayID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayData)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DsFyPay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FyOrderID).HasColumnName("FyOrderID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.PayID).HasColumnName("PayID");
            this.Property(t => t.PayData).HasColumnName("PayData");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
