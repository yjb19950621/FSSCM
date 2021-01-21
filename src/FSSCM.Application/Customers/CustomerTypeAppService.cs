using System;
using FSSCM.Permissions;
using FSSCM.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Customers
{
    public class CustomerTypeAppService : CrudAppService<CustomerType, CustomerTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerTypeDto, CreateUpdateCustomerTypeDto>,
        ICustomerTypeAppService
    {
        protected override string GetPolicyName { get; set; } = FSSCMPermissions.CustomerType.Default;
        protected override string GetListPolicyName { get; set; } = FSSCMPermissions.CustomerType.Default;
        protected override string CreatePolicyName { get; set; } = FSSCMPermissions.CustomerType.Create;
        protected override string UpdatePolicyName { get; set; } = FSSCMPermissions.CustomerType.Update;
        protected override string DeletePolicyName { get; set; } = FSSCMPermissions.CustomerType.Delete;

        private readonly ICustomerTypeRepository _repository;
        
        public CustomerTypeAppService(ICustomerTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
