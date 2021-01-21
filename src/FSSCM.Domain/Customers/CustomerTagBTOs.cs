using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FSSCM.Customers
{
    public class CustomerTagBTOs : AuditedAggregateRoot<int>
    {
        public string CustomerId { get; set; }
        public string TagId { get; set; }
        public string TenantId { get; set; }

        protected CustomerTagBTOs()
        {
        }

        public CustomerTagBTOs(
            int id,
            string customerId,
            string tagId,
            string tenantId
        ) : base(id)
        {
            CustomerId = customerId;
            TagId = tagId;
            TenantId = tenantId;
        }
    }
}
