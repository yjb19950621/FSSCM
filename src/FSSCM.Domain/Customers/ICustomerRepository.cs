using System;
using Volo.Abp.Domain.Repositories;

namespace FSSCM.Customers
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
    }
}