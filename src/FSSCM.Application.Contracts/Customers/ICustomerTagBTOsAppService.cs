using System;
using FSSCM.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Customers
{
    public interface ICustomerTagBTOsAppService :
        ICrudAppService< 
            CustomerTagBTOsDto, 
            int, 
            PagedAndSortedResultRequestDto,
            CreateUpdateCustomerTagBTOsDto,
            CreateUpdateCustomerTagBTOsDto>
    {

    }
}