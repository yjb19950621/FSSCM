using System;
using System.Linq;
using System.Threading.Tasks;
using FSSCM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FSSCM.Product
{
    public class GoodsUnitRepository : EfCoreRepository<FSSCMDbContext, GoodsUnit, Guid>, IGoodsUnitRepository
    {
        public GoodsUnitRepository(IDbContextProvider<FSSCMDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<GoodsUnit> FindByNameAsync(string name)
        {
            return await DbContext.Set<GoodsUnit>()
            .Where(p => p.GoodsUnitName == name)
            .FirstOrDefaultAsync();
        }
        public GoodsUnit FindByName(string name)
        {
            return DbContext.Set<GoodsUnit>()
            .Where(p => p.GoodsUnitName == name)
            .FirstOrDefault();
        }
    }
}