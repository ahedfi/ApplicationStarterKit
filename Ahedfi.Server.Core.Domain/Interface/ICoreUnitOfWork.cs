using Ahedfi.Component.Data.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICoreUnitOfWork : IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
    }
}
