using System;
using System.ComponentModel;
namespace FSSCM.Customers.Dtos
{
    [Serializable]
    public class CreateUpdateCustomerTagBTOsDto
    {
        public string CustomerId { get; set; }

        public string TagId { get; set; }

        public string TenantId { get; set; }
    }
}