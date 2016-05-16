using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class DsFocuMap : EntityTypeConfiguration<DsFocu>
    {
        public DsFocuMap()
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

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ContentText)
                .IsRequired();

            this.Property(t => t.ShortTitle)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ShortContentText)
                .IsRequired();

            this.Property(t => t.CreateUserID)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BuildingGroupID)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DsFocus");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SequenceCode).HasColumnName("SequenceCode");
            this.Property(t => t.FocusQueueType).HasColumnName("FocusQueueType");
            this.Property(t => t.FocusQueueStartTime).HasColumnName("FocusQueueStartTime");
            this.Property(t => t.FocusQueueEndTime).HasColumnName("FocusQueueEndTime");
            this.Property(t => t.OpenStartTime).HasColumnName("OpenStartTime");
            this.Property(t => t.OpenEndTime).HasColumnName("OpenEndTime");
            this.Property(t => t.SimulateOpenStartTime).HasColumnName("SimulateOpenStartTime");
            this.Property(t => t.SimulateOpenEndTime).HasColumnName("SimulateOpenEndTime");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ContentText).HasColumnName("ContentText");
            this.Property(t => t.ShortTitle).HasColumnName("ShortTitle");
            this.Property(t => t.ShortContentText).HasColumnName("ShortContentText");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateUserID).HasColumnName("CreateUserID");
            this.Property(t => t.BuildingGroupID).HasColumnName("BuildingGroupID");
        }
    }
}
