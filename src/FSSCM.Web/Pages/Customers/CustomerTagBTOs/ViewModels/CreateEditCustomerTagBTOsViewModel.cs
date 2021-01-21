using System;

using System.ComponentModel.DataAnnotations;

namespace FSSCM.Web.Pages.Customers.CustomerTagBTOs.ViewModels
{
    public class CreateEditCustomerTagBTOsViewModel
    {
        [Display(Name = "CustomerTagBTOsCustomerId")]
        public string CustomerId { get; set; }

        [Display(Name = "CustomerTagBTOsTagId")]
        public string TagId { get; set; }

        [Display(Name = "CustomerTagBTOsTenantId")]
        public string TenantId { get; set; }
    }
}