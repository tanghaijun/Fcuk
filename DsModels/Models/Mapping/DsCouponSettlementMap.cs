using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsCouponSettlementMap : EntityTypeConfiguration<DsCouponSettlement>
    {
        public DsCouponSettlementMap()
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

            this.Property(t => t.ApplyRemark)
                .IsRequired();

            this.Property(t => t.HandleRemark)
                .IsRequired();

            this.Property(t => t.ApplyUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.HandleUserID)
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

            // Table & Column Mappings
            this.ToTable("DsCouponSettlement");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ApplyRemark).HasColumnName("ApplyRemark");
            this.Property(t => t.HandleRemark).HasColumnName("HandleRemark");
            this.Property(t => t.ApplyUserID).HasColumnName("ApplyUserID");
            this.Property(t => t.HandleUserID).HasColumnName("HandleUserID");
            this.Property(t => t.CardOwner).HasColumnName("CardOwner");
            this.Property(t => t.CardNumber).HasColumnName("CardNumber");
            this.Property(t => t.CardBank).HasColumnName("CardBank");
            this.Property(t => t.CardCityCode).HasColumnName("CardCityCode");
            this.Property(t => t.TotalOrderPrice).HasColumnName("TotalOrderPrice");
            this.Property(t => t.TotalOrderCost).HasColumnName("TotalOrderCost");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
