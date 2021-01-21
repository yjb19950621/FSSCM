using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FSSCM.Customers
{
    public class CustomerType : AuditedAggregateRoot<Guid>
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

        protected CustomerType()
        {
        }

        public CustomerType(
            Guid id,
            int isDefault,
            string name,
            decimal discountrate,
            int allProductType,
            int allProductBrand,
            string productBrandIds,
            string productTypeIds,
            int sortNum,
            string tenantId
        ) : base(id)
        {
            IsDefault = isDefault;
            Name = name;
            Discountrate = discountrate;
            AllProductType = allProductType;
            AllProductBrand = allProductBrand;
            ProductBrandIds = productBrandIds;
            ProductTypeIds = productTypeIds;
            SortNum = sortNum;
            TenantId = tenantId;
        }
    }
}
