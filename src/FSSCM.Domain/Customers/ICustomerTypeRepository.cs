using System;
using Volo.Abp.Domain.Repositories;

namespace FSSCM.Customers
{
    public interface ICustomerTypeRepository : IRepository<CustomerType, Guid>
    {
    }
}