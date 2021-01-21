using System;
using System.ComponentModel;
namespace FSSCM.Customers.Dtos
{
    [Serializable]
    public class CreateUpdateCustomerTypeDto
    {
        public int IsDefault { get; set; }

        public string Name { get; set; }

        public decimal Discountrate { get; set; }

        public int AllProductType { get; set; }

        public int AllProductBrand { get; set; }

        public string ProductBrandIds { get; set; }

        public string ProductTypeIds { get; set; }

        public int SortNum { get; set; }

        public string TenantId { get; set; }
    }
}