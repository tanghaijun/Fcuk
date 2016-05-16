using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DsModels.Models.Mapping
{
    public class rsync_dataMap : EntityTypeConfiguration<rsync_data>
    {
        public rsync_dataMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("rsync_data");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.test_str).HasColumnName("test_str");
        }
    }
}
