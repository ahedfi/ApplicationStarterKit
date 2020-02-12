using Ahedfi.Component.Core.Domain.Entities;
using Ahedfi.Component.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core.Domain.Entities
{
    public class Customer : AuditableEntity<int>, IAggregateRoot
    {
        public string Name { get; set; }
    }
}
