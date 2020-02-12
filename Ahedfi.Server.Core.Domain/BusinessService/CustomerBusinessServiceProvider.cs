using Ahedfi.Server.Core.Domain.Entities;
using Ahedfi.Server.Core.Domain.Interface;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.BusinessService
{
    public class CustomerBusinessServiceProvider : ICustomerBusinessServiceProvider
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerBusinessServiceProvider(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<Customer> AddCustomer()
        {
            return await _customerRepository.AddAsync(new Customer { Name = "Ahmed" });
        }
    }
}
