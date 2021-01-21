using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FSSCM.Product
{
    public static class GoodsUnitEfCoreQueryableExtensions
    {
        public static IQueryable<GoodsUnit> IncludeDetails(this IQueryable<GoodsUnit> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}