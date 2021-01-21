using System;
using FSSCM.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Customers
{
    public interface ICustomerAppService :
        ICrudAppService< 
            CustomerDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateCustomerDto,
            CreateUpdateCustomerDto>
    {

    }
}