using Ahedfi.Component.Core.Domain.Models.Entities;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Ahedfi.Server.Core.Domain.Entities
{
    public class Address: AuditableEntity<int>, IEquatable<Address>
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Address);
        }

        public bool Equals([AllowNull] Address other)
        {
            return other != null &&
                   Street == other.Street &&
                   City == other.City &&
                   State == other.State &&
                   Country == other.Country &&
                   ZipCode == other.ZipCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Street, City, State, Country, ZipCode);
        }
    }
}
