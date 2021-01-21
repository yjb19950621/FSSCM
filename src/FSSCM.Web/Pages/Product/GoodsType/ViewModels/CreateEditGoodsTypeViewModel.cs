using System;

using System.ComponentModel.DataAnnotations;

namespace FSSCM.Web.Pages.Product.GoodsType.ViewModels
{
    public class CreateEditGoodsTypeViewModel
    {
        [Display(Name = "GoodsTypeTypeCode")]
        public string TypeCode { get; set; }

        [Display(Name = "GoodsTypeTypeName")]
        public string TypeName { get; set; }

        [Display(Name = "GoodsTypeIsDefault")]
        public int IsDefault { get; set; }

        [Display(Name = "GoodsTypeLeafTypeFlag")]
        public string LeafTypeFlag { get; set; }

        [Display(Name = "GoodsTypeMainImg")]
        public string MainImg { get; set; }

        [Display(Name = "GoodsTypeMainImgUrl")]
        public string MainImgUrl { get; set; }

        [Display(Name = "GoodsTypeImgUrl")]
        public string ImgUrl { get; set; }

        [Display(Name = "GoodsTypeParentTypeId")]
        public string ParentTypeId { get; set; }

        [Display(Name = "GoodsTypeShowPageType")]
        public int ShowPageType { get; set; }

        [Display(Name = "GoodsTypeOrder")]
        public int Order { get; set; }

        [Display(Name = "GoodsTypeTypeLevel")]
        public int TypeLevel { get; set; }

        [Display(Name = "GoodsTypeTenantId")]
        public string TenantId { get; set; }
    }
}