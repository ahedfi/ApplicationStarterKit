using Ahedfi.Server.Core.Domain.Interface;

namespace Ahedfi.Server.Core.Domain.BusinessService
{
    public class BusinessService : IBusinessService
    {
        public string SayHello()
        {
            return "hello world !!";
        }
    }
}
