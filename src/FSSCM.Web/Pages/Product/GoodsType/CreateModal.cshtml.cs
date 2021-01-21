using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Product;
using FSSCM.Product.Dtos;
using FSSCM.Web.Pages.Product.GoodsType.ViewModels;

namespace FSSCM.Web.Pages.Product.GoodsType
{
    public class CreateModalModel : FSSCMPageModel
    {
        [BindProperty]
        public CreateEditGoodsTypeViewModel ViewModel { get; set; }

        private readonly IGoodsTypeAppService _service;

        public CreateModalModel(IGoodsTypeAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditGoodsTypeViewModel, CreateUpdateGoodsTypeDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}