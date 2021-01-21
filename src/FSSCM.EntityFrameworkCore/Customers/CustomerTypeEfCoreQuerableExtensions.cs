using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FSSCM.Customers
{
    public static class CustomerTypeEfCoreQueryableExtensions
    {
        public static IQueryable<CustomerType> IncludeDetails(this IQueryable<CustomerType> queryable, bool include = true)
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