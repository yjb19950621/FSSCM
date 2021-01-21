using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Customers;
using FSSCM.Customers.Dtos;
using FSSCM.Web.Pages.Customers.CustomerTagBTOs.ViewModels;

namespace FSSCM.Web.Pages.Customers.CustomerTagBTOs
{
    public class CreateModalModel : FSSCMPageModel
    {
        [BindProperty]
        public CreateEditCustomerTagBTOsViewModel ViewModel { get; set; }

        private readonly ICustomerTagBTOsAppService _service;

        public CreateModalModel(ICustomerTagBTOsAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerTagBTOsViewModel, CreateUpdateCustomerTagBTOsDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}