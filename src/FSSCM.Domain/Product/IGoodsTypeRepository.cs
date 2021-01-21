using System;
using Volo.Abp.Domain.Repositories;

namespace FSSCM.Product
{
    public interface IGoodsTypeRepository : IRepository<GoodsType, Guid>
    {
    }
}