using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FSSCM.Product
{
    public static class GoodsTypeEfCoreQueryableExtensions
    {
        public static IQueryable<GoodsType> IncludeDetails(this IQueryable<GoodsType> queryable, bool include = true)
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