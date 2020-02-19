using Ahedfi.Component.Core.Domain.Models.Entities;

namespace Ahedfi.Server.Core.Domain.Entities
{
    public class Address: AuditableEntity<int>
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

    }
}
