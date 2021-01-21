using System;
using Volo.Abp.Application.Dtos;

namespace FSSCM.Product.Dtos
{
    [Serializable]
    public class GoodsTypeDto : AuditedEntityDto<Guid>
    {
        public string TypeCode { get; set; }

        public string TypeName { get; set; }

        public int IsDefault { get; set; }

        public string LeafTypeFlag { get; set; }

        public string MainImg { get; set; }

        public string MainImgUrl { get; set; }

        public string ImgUrl { get; set; }

        public string ParentTypeId { get; set; }

        public int ShowPageType { get; set; }

        public int Order { get; set; }

        public int TypeLevel { get; set; }

        public string TenantId { get; set; }
    }
}