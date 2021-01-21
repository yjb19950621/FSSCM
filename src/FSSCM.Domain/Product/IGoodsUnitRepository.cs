using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FSSCM.Product
{
    public interface IGoodsUnitRepository : IRepository<GoodsUnit, Guid>
    {
       public Task<GoodsUnit> FindByNameAsync(string name);
       public GoodsUnit FindByName(string name);
    }
}