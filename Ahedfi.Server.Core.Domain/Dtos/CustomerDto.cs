using Ahedfi.Component.Core.Domain.Models.Entities;
using System;

namespace Ahedfi.Server.Core.Domain.Dtos
{
    public class CustomerDto : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
