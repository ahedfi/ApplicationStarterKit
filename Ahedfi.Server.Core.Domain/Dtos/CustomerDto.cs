using Ahedfi.Component.Core.Domain.Models.Entities;
using System;
using System.Collections.Generic;

namespace Ahedfi.Server.Core.Domain.Dtos
{
    public class CustomerDto : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AddressDto SecondAddress { get; set; }
        public ICollection<AddressDto> Addresses { get; set; }
    }
}
