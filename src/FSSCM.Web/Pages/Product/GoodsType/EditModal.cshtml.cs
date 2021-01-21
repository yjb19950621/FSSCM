using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Product;
using FSSCM.Product.Dtos;
using FSSCM.Web.Pages.Product.GoodsType.ViewModels;

namespace FSSCM.Web.Pages.Product.GoodsType
{
    public class EditModalModel : FSSCMPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditGoodsTypeViewModel ViewModel { get; set; }

        private readonly IGoodsTypeAppService _service;

        public EditModalModel(IGoodsTypeAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<GoodsTypeDto, CreateEditGoodsTypeViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditGoodsTypeViewModel, CreateUpdateGoodsTypeDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}