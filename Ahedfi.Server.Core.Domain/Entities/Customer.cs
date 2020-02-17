using Ahedfi.Component.Core.Domain.Models.Entities;
using Ahedfi.Component.Core.Domain.Models.Interfaces;

namespace Ahedfi.Server.Core.Domain.Entities
{
    public class Customer : AuditableEntity<int>, IAggregateRoot
    {
        public string Name { get; set; }
    }
}
