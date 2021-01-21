using System;

using System.ComponentModel.DataAnnotations;

namespace FSSCM.Web.Pages.Customers.Customer.ViewModels
{
    public class CreateEditCustomerViewModel
    {
        [Display(Name = "CustomerUserName")]
        public string UserName { get; set; }

        [Display(Name = "CustomerName")]
        public string Name { get; set; }

        [Display(Name = "CustomerCustomerStatus")]
        public int CustomerStatus { get; set; }

        [Display(Name = "CustomerCode")]
        public string Code { get; set; }

        [Display(Name = "CustomerCustomRegionId")]
        public string CustomRegionId { get; set; }

        [Display(Name = "CustomerCompanyUserId")]
        public string CompanyUserId { get; set; }

        [Display(Name = "CustomerLogisticsCode")]
        public string LogisticsCode { get; set; }

        [Display(Name = "CustomerCustomerTypeId")]
        public string CustomerTypeId { get; set; }

        [Display(Name = "CustomerWarehouseId")]
        public string WarehouseId { get; set; }

        [Display(Name = "CustomerZipCode")]
        public string ZipCode { get; set; }

        [Display(Name = "CustomerSuperiorStatus")]
        public int SuperiorStatus { get; set; }

        [Display(Name = "CustomerExtra")]
        public string Extra { get; set; }

        [Display(Name = "Customerfax")]
        public string fax { get; set; }

        [Display(Name = "CustomerAddress")]
        public string Address { get; set; }

        [Display(Name = "CustomerActiveCustomer")]
        public int ActiveCustomer { get; set; }

        [Display(Name = "CustomerSuperiorEmployeeId")]
        public string SuperiorEmployeeId { get; set; }

        [Display(Name = "CustomerSuperiorCustomerId")]
        public string SuperiorCustomerId { get; set; }

        [Display(Name = "CustomerSettlement")]
        public string Settlement { get; set; }

        [Display(Name = "CustomerContactor")]
        public string Contactor { get; set; }

        [Display(Name = "CustomerPosition")]
        public string Position { get; set; }

        [Display(Name = "CustomerMobile")]
        public string Mobile { get; set; }

        [Display(Name = "CustomerPhone")]
        public string Phone { get; set; }

        [Display(Name = "CustomerEmail")]
        public string Email { get; set; }

        [Display(Name = "CustomerQQ")]
        public string QQ { get; set; }

        [Display(Name = "CustomerInvoice")]
        public string Invoice { get; set; }

        [Display(Name = "CustomerTaxNum")]
        public string TaxNum { get; set; }

        [Display(Name = "CustomerInvoiceAddress")]
        public string InvoiceAddress { get; set; }

        [Display(Name = "CustomerInvoiceMobile")]
        public string InvoiceMobile { get; set; }

        [Display(Name = "CustomerBankName")]
        public string BankName { get; set; }

        [Display(Name = "CustomerBank")]
        public string Bank { get; set; }

        [Display(Name = "CustomerBankAccount")]
        public string BankAccount { get; set; }

        [Display(Name = "CustomerDebtTypeId")]
        public string DebtTypeId { get; set; }

        [Display(Name = "CustomerIsDebtInit")]
        public int IsDebtInit { get; set; }

        [Display(Name = "CustomerLastReconciliationTime")]
        public string LastReconciliationTime { get; set; }

        [Display(Name = "CustomerLongitude")]
        public string Longitude { get; set; }

        [Display(Name = "CustomerLatitude")]
        public string Latitude { get; set; }

        [Display(Name = "CustomerBeginSign")]
        public DateTime BeginSign { get; set; }

        [Display(Name = "CustomerEndSign")]
        public DateTime EndSign { get; set; }

        [Display(Name = "CustomerCountryId")]
        public int CountryId { get; set; }

        [Display(Name = "CustomerProvinceId")]
        public int ProvinceId { get; set; }

        [Display(Name = "CustomerCityId")]
        public int CityId { get; set; }

        [Display(Name = "CustomerDistrictId")]
        public int DistrictId { get; set; }

        [Display(Name = "CustomerTagIds")]
        public string TagIds { get; set; }

        [Display(Name = "CustomerTenantId")]
        public string TenantId { get; set; }
    }
}