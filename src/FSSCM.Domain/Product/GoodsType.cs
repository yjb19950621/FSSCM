using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FSSCM.Product
{
   public class GoodsType: AuditedAggregateRoot<Guid>
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

        protected GoodsType()
        {
        }

        public GoodsType(
            Guid id,
            string typeCode,
            string typeName,
            int isDefault,
            string leafTypeFlag,
            string mainImg,
            string mainImgUrl,
            string imgUrl,
            string parentTypeId,
            int showPageType,
            int order,
            int typeLevel,
            string tenantId
        ) : base(id)
        {
            TypeCode = typeCode;
            TypeName = typeName;
            IsDefault = isDefault;
            LeafTypeFlag = leafTypeFlag;
            MainImg = mainImg;
            MainImgUrl = mainImgUrl;
            ImgUrl = imgUrl;
            ParentTypeId = parentTypeId;
            ShowPageType = showPageType;
            Order = order;
            TypeLevel = typeLevel;
            TenantId = tenantId;
        }
    }
}
