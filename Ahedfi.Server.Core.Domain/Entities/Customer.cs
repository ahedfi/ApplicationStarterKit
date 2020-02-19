using Ahedfi.Component.Core.Domain.Models.Entities;
using Ahedfi.Component.Core.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace Ahedfi.Server.Core.Domain.Entities
{
    public class Customer : AuditableEntity<int>, IAggregateRoot
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
        }
        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
