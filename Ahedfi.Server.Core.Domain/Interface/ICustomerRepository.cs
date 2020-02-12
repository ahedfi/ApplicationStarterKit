using Ahedfi.Component.Data.Domain.Interfaces;
using Ahedfi.Server.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICustomerRepository : IAsyncRepository<Customer>
    {
    }
}
