using System;
using FSSCM.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FSSCM.Customers
{
    public class CustomerTagBTOsRepository : EfCoreRepository<FSSCMDbContext, CustomerTagBTOs, int>, ICustomerTagBTOsRepository
    {
        public CustomerTagBTOsRepository(IDbContextProvider<FSSCMDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}