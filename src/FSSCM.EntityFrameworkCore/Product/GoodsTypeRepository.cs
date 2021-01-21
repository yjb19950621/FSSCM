using System;
using FSSCM.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FSSCM.Product
{
    public class GoodsTypeRepository : EfCoreRepository<FSSCMDbContext, GoodsType, Guid>, IGoodsTypeRepository
    {
        public GoodsTypeRepository(IDbContextProvider<FSSCMDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}