using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Product;
using FSSCM.Product.Dtos;
using FSSCM.Web.Pages.Product.GoodsUnit.ViewModels;

namespace FSSCM.Web.Pages.Product.GoodsUnit
{
    public class CreateModalModel : FSSCMPageModel
    {
        [BindProperty]
        public CreateEditGoodsUnitViewModel ViewModel { get; set; }

        private readonly IGoodsUnitAppService _service;

        public CreateModalModel(IGoodsUnitAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditGoodsUnitViewModel, CreateUpdateGoodsUnitDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}