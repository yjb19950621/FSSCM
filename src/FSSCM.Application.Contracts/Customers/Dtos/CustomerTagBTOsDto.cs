using System;
using Volo.Abp.Application.Dtos;

namespace FSSCM.Customers.Dtos
{
    [Serializable]
    public class CustomerTagBTOsDto : AuditedEntityDto<int>
    {
        public string CustomerId { get; set; }

        public string TagId { get; set; }

        public string TenantId { get; set; }
    }
}