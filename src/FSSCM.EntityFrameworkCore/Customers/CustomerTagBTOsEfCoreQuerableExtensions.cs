using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FSSCM.Customers
{
    public static class CustomerTagBTOsEfCoreQueryableExtensions
    {
        public static IQueryable<CustomerTagBTOs> IncludeDetails(this IQueryable<CustomerTagBTOs> queryable, bool include = true)
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