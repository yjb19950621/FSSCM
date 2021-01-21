using System;
using FSSCM.Permissions;
using FSSCM.Product.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Product
{
    public class GoodsTypeAppService : CrudAppService<GoodsType, GoodsTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsTypeDto, CreateUpdateGoodsTypeDto>,
        IGoodsTypeAppService
    {
        protected override string GetPolicyName { get; set; } = FSSCMPermissions.GoodsType.Default;
        protected override string GetListPolicyName { get; set; } = FSSCMPermissions.GoodsType.Default;
        protected override string CreatePolicyName { get; set; } = FSSCMPermissions.GoodsType.Create;
        protected override string UpdatePolicyName { get; set; } = FSSCMPermissions.GoodsType.Update;
        protected override string DeletePolicyName { get; set; } = FSSCMPermissions.GoodsType.Delete;

        private readonly IGoodsTypeRepository _repository;
        
        public GoodsTypeAppService(IGoodsTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
