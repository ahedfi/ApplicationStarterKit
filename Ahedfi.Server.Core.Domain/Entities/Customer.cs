using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
}
