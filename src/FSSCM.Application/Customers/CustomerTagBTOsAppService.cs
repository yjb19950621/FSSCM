using System;
using FSSCM.Permissions;
using FSSCM.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Customers
{
    public class CustomerTagBTOsAppService : CrudAppService<CustomerTagBTOs, CustomerTagBTOsDto, int, PagedAndSortedResultRequestDto, CreateUpdateCustomerTagBTOsDto, CreateUpdateCustomerTagBTOsDto>,
        ICustomerTagBTOsAppService
    {
        protected override string GetPolicyName { get; set; } = FSSCMPermissions.CustomerTagBTOs.Default;
        protected override string GetListPolicyName { get; set; } = FSSCMPermissions.CustomerTagBTOs.Default;
        protected override string CreatePolicyName { get; set; } = FSSCMPermissions.CustomerTagBTOs.Create;
        protected override string UpdatePolicyName { get; set; } = FSSCMPermissions.CustomerTagBTOs.Update;
        protected override string DeletePolicyName { get; set; } = FSSCMPermissions.CustomerTagBTOs.Delete;

        private readonly ICustomerTagBTOsRepository _repository;
        
        public CustomerTagBTOsAppService(ICustomerTagBTOsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
