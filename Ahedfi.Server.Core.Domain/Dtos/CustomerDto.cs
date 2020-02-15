using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core.Domain.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
