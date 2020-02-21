using Ahedfi.Component.Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ahedfi.Server.Core.Infrastructure.Data.EntityConfigurations
{
    //public int Id { get; set; }
    //public string UserName { get; set; }
    //public string ObjectName { get; set; }
    //public string ObjectId { get; set; }
    //public string PropertyName { get; set; }
    //public string PropertyType { get; set; }
    //public string OldValue { get; set; }
    //public string NewValue { get; set; }
    //public string ChangeType { get; set; }
    //public DateTime Date { get; set; }
    //public Guid BatchId { get; set; }
public class AuditConfiguration : IEntityTypeConfiguration<AuditTrail>
    {
        public void Configure(EntityTypeBuilder<AuditTrail> builder)
        {
            builder.ToTable("APP_AUD_Audits");
            builder.HasKey(t => t.Id);

        }
    }
}
