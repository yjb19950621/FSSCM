using System;
using System.ComponentModel;
namespace FSSCM.Product.Dtos
{
    [Serializable]
    public class CreateUpdateGoodsUnitDto
    {
        public string GoodsUnitName { get; set; }

        public int Status { get; set; }

        public string TenantId { get; set; }
    }
}