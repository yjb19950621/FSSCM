using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace FSSCM.Product
{
   public class GoodsUnit:AuditedAggregateRoot<Guid>
    {
        public string GoodsUnitName { get; set; }
        public int Status { get; set; }      
        public string TenantId { get; set; } 

        protected GoodsUnit()
        {
        }
        public GoodsUnit(
            Guid id,
            string goodsUnitName,
            int status,
            string tenantId
        ) : base(id)
        {
            GoodsUnitName = goodsUnitName;
            Status = status;
            TenantId = tenantId;
        }
    }
}
