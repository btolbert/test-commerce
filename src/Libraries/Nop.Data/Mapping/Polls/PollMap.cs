using System.Data.Entity.ModelConfiguration;
using Nop.Core.Domain.Polls;

namespace Nop.Data.Mapping.Polls
{
    public partial class PollMap : EntityTypeConfiguration<Poll>
    {
        public PollMap()
        {
            this.ToTable("Poll");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired().IsMaxLength();
            
            this.HasRequired(p => p.Language)
                .WithMany()
                .HasForeignKey(p => p.LanguageId).WillCascadeOnDelete(true);
        }
    }
}