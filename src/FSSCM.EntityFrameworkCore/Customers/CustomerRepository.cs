using System;
using FSSCM.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FSSCM.Customers
{
    public class CustomerRepository : EfCoreRepository<FSSCMDbContext, Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(IDbContextProvider<FSSCMDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}