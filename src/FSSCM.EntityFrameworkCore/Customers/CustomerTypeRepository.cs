using System;
using FSSCM.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FSSCM.Customers
{
    public class CustomerTypeRepository : EfCoreRepository<FSSCMDbContext, CustomerType, Guid>, ICustomerTypeRepository
    {
        public CustomerTypeRepository(IDbContextProvider<FSSCMDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}