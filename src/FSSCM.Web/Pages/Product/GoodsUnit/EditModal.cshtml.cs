using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Product;
using FSSCM.Product.Dtos;
using FSSCM.Web.Pages.Product.GoodsUnit.ViewModels;

namespace FSSCM.Web.Pages.Product.GoodsUnit
{
    public class EditModalModel : FSSCMPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditGoodsUnitViewModel ViewModel { get; set; }

        private readonly IGoodsUnitAppService _service;

        public EditModalModel(IGoodsUnitAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<GoodsUnitDto, CreateEditGoodsUnitViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditGoodsUnitViewModel, CreateUpdateGoodsUnitDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}