using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FSSCM.Customers
{
    public class Customer : AuditedAggregateRoot<Guid>
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

        protected Customer()
        {
        }

        public Customer(
            Guid id,
            string userName,
            string name,
            int customerStatus,
            string code,
            string customRegionId,
            string companyUserId,
            string logisticsCode,
            string customerTypeId,
            string warehouseId,
            string zipCode,
            int superiorStatus,
            string extra,
            string fax,
            string address,
            int activeCustomer,
            string superiorEmployeeId,
            string superiorCustomerId,
            string settlement,
            string contactor,
            string position,
            string mobile,
            string phone,
            string email,
            string qQ,
            string invoice,
            string taxNum,
            string invoiceAddress,
            string invoiceMobile,
            string bankName,
            string bank,
            string bankAccount,
            string debtTypeId,
            int isDebtInit,
            string lastReconciliationTime,
            string longitude,
            string latitude,
            DateTime beginSign,
            DateTime endSign,
            int countryId,
            int provinceId,
            int cityId,
            int districtId,
            string tagIds,
            string tenantId
        ) : base(id)
        {
            UserName = userName;
            Name = name;
            CustomerStatus = customerStatus;
            Code = code;
            CustomRegionId = customRegionId;
            CompanyUserId = companyUserId;
            LogisticsCode = logisticsCode;
            CustomerTypeId = customerTypeId;
            WarehouseId = warehouseId;
            ZipCode = zipCode;
            SuperiorStatus = superiorStatus;
            Extra = extra;
            fax = fax;
            Address = address;
            ActiveCustomer = activeCustomer;
            SuperiorEmployeeId = superiorEmployeeId;
            SuperiorCustomerId = superiorCustomerId;
            Settlement = settlement;
            Contactor = contactor;
            Position = position;
            Mobile = mobile;
            Phone = phone;
            Email = email;
            QQ = qQ;
            Invoice = invoice;
            TaxNum = taxNum;
            InvoiceAddress = invoiceAddress;
            InvoiceMobile = invoiceMobile;
            BankName = bankName;
            Bank = bank;
            BankAccount = bankAccount;
            DebtTypeId = debtTypeId;
            IsDebtInit = isDebtInit;
            LastReconciliationTime = lastReconciliationTime;
            Longitude = longitude;
            Latitude = latitude;
            BeginSign = beginSign;
            EndSign = endSign;
            CountryId = countryId;
            ProvinceId = provinceId;
            CityId = cityId;
            DistrictId = districtId;
            TagIds = tagIds;
            TenantId = tenantId;
        }
    }
}
