using Ahedfi.Component.Data.Infrastructure;
using Ahedfi.Server.Core.Domain.Interface;

namespace Ahedfi.Server.Core.Infrastructure.Data
{
    public class CoreUnitOfWork : UnitOfWork<CoreContext>, ICoreUnitOfWork
    {
        private ICustomerRepository _customerRepository;

        public CoreUnitOfWork(CoreContext coreContext) : base(coreContext)
        { }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_context);
                }

                return _customerRepository;
            }
        }

    }
}
