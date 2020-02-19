using Ahedfi.Component.Core.Domain.Models.Entities;

namespace Ahedfi.Server.Core.Domain.Dtos
{
    public class AddressDto : Entity
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
