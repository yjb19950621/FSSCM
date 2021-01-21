using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSSCM.Permissions;
using FSSCM.Product.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSSCM.Product
{
    public class GoodsUnitAppService : CrudAppService<GoodsUnit, GoodsUnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsUnitDto, CreateUpdateGoodsUnitDto>, IGoodsUnitAppService
    {
        protected override string GetPolicyName { get; set; } = FSSCMPermissions.GoodsUnit.Default;
        protected override string GetListPolicyName { get; set; } = FSSCMPermissions.GoodsUnit.Default;
        protected override string CreatePolicyName { get; set; } = FSSCMPermissions.GoodsUnit.Create;
        protected override string UpdatePolicyName { get; set; } = FSSCMPermissions.GoodsUnit.Update;
        protected override string DeletePolicyName { get; set; } = FSSCMPermissions.GoodsUnit.Delete;

        private readonly IGoodsUnitRepository _repository;
        
        public GoodsUnitAppService(IGoodsUnitRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public GoodsUnitDto GetGoodsUnit(string name)
        {
            var obj =  _repository.FindByName(name);
            return ObjectMapper.Map<GoodsUnit, GoodsUnitDto>(obj);
        }
        //[HttpGet]
        //public async Task<GoodsUnitDto> GetGoodsUnitAsync(string name)
        //{
        //    var obj= await _repository.FindByNameAsync(name);
        //    return ObjectMapper.Map<GoodsUnit,GoodsUnitDto>(obj);
        //}
    }
}
