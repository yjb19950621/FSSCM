using System;
using System.Threading.Tasks;
using FSSCM.Product.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Product
{
    public interface IGoodsUnitAppService :
        ICrudAppService< 
            GoodsUnitDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateGoodsUnitDto,
            CreateUpdateGoodsUnitDto>,IApplicationService
    {
        //Task<GoodsUnitDto> GetGoodsUnitAsync(string name);
        GoodsUnitDto GetGoodsUnit(string name);
    }
}