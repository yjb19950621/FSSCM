using System;
using Volo.Abp.Application.Dtos;

namespace FSSCM.Product.Dtos
{
    [Serializable]
    public class GoodsUnitDto : AuditedEntityDto<Guid>
    {
        public string GoodsUnitName { get; set; }

        public int Status { get; set; }

        public string TenantId { get; set; }
    }
}