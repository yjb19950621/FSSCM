using System;

using System.ComponentModel.DataAnnotations;

namespace FSSCM.Web.Pages.Product.GoodsUnit.ViewModels
{
    public class CreateEditGoodsUnitViewModel
    {
        [Display(Name = "GoodsUnitGoodsUnitName")]
        public string GoodsUnitName { get; set; }

        [Display(Name = "GoodsUnitStatus")]
        public int Status { get; set; }

        [Display(Name = "GoodsUnitTenantId")]
        public string TenantId { get; set; }
    }
}