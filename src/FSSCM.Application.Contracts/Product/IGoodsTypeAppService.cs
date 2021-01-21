using System;
using FSSCM.Product.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Product
{
    public interface IGoodsTypeAppService :
        ICrudAppService< 
            GoodsTypeDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateGoodsTypeDto,
            CreateUpdateGoodsTypeDto>
    {
        
    }
}