using System;
using Volo.Abp.Application.Dtos;

namespace FSSCM.Customers.Dtos
{
    [Serializable]
    public class CustomerDto : AuditedEntityDto<Guid>
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public int CustomerStatus { get; set; }

        public string Code { get; set; }

        public string CustomRegionId { get; set; }

        public string CompanyUserId { get; set; }

        public string LogisticsCode { get; set; }

        public string CustomerTypeId { get; set; }

        public string WarehouseId { get; set; }

        public string ZipCode { get; set; }

        public int SuperiorStatus { get; set; }

        public string Extra { get; set; }

        public string fax { get; set; }

        public string Address { get; set; }

        public int ActiveCustomer { get; set; }

        public string SuperiorEmployeeId { get; set; }

        public string SuperiorCustomerId { get; set; }

        public string Settlement { get; set; }

        public string Contactor { get; set; }

        public string Position { get; set; }

        public string Mobile { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string QQ { get; set; }

        public string Invoice { get; set; }

        public string TaxNum { get; set; }

        public string InvoiceAddress { get; set; }

        public string InvoiceMobile { get; set; }

        public string BankName { get; set; }

        public string Bank { get; set; }

        public string BankAccount { get; set; }

        public string DebtTypeId { get; set; }

        public int IsDebtInit { get; set; }

        public string LastReconciliationTime { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public DateTime BeginSign { get; set; }

        public DateTime EndSign { get; set; }

        public int CountryId { get; set; }

        public int ProvinceId { get; set; }

        public int CityId { get; set; }

        public int DistrictId { get; set; }

        public string TagIds { get; set; }

        public string TenantId { get; set; }
    }
}