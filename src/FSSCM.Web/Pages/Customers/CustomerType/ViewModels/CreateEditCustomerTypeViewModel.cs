using System;

using System.ComponentModel.DataAnnotations;

namespace FSSCM.Web.Pages.Customers.CustomerType.ViewModels
{
    public class CreateEditCustomerTypeViewModel
    {
        [Display(Name = "CustomerTypeIsDefault")]
        public int IsDefault { get; set; }

        [Display(Name = "CustomerTypeName")]
        public string Name { get; set; }

        [Display(Name = "CustomerTypeDiscountrate")]
        public decimal Discountrate { get; set; }

        [Display(Name = "CustomerTypeAllProductType")]
        public int AllProductType { get; set; }

        [Display(Name = "CustomerTypeAllProductBrand")]
        public int AllProductBrand { get; set; }

        [Display(Name = "CustomerTypeProductBrandIds")]
        public string ProductBrandIds { get; set; }

        [Display(Name = "CustomerTypeProductTypeIds")]
        public string ProductTypeIds { get; set; }

        [Display(Name = "CustomerTypeSortNum")]
        public int SortNum { get; set; }

        [Display(Name = "CustomerTypeTenantId")]
        public string TenantId { get; set; }
    }
}