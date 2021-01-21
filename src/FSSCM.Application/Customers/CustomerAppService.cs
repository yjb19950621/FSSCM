using System;
using FSSCM.Permissions;
using FSSCM.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Customers
{
    public class CustomerAppService : CrudAppService<Customer, CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto, CreateUpdateCustomerDto>,
        ICustomerAppService
    {
        protected override string GetPolicyName { get; set; } = FSSCMPermissions.Customer.Default;
        protected override string GetListPolicyName { get; set; } = FSSCMPermissions.Customer.Default;
        protected override string CreatePolicyName { get; set; } = FSSCMPermissions.Customer.Create;
        protected override string UpdatePolicyName { get; set; } = FSSCMPermissions.Customer.Update;
        protected override string DeletePolicyName { get; set; } = FSSCMPermissions.Customer.Delete;

        private readonly ICustomerRepository _repository;
        
        public CustomerAppService(ICustomerRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
