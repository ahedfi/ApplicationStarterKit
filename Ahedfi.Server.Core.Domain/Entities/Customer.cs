using Ahedfi.Component.Core.Domain.Models.Entities;
using Ahedfi.Component.Core.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Ahedfi.Server.Core.Domain.Entities
{
    public class Customer : AuditableEntity<int>, IAggregateRoot, IEquatable<Customer>
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
        }
        public string Name { get; set; }

        public Address SecondAddress{ get; set; }

        public ICollection<Address> Addresses { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals([AllowNull] Customer other)
        {
            return other != null &&
                   Name == other.Name &&
                   EqualityComparer<Address>.Default.Equals(SecondAddress, other.SecondAddress) &&
                   EqualityComparer<ICollection<Address>>.Default.Equals(Addresses, other.Addresses);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, SecondAddress, Addresses);
        }
    }
}
