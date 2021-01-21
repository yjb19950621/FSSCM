using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Customers;
using FSSCM.Customers.Dtos;
using FSSCM.Web.Pages.Customers.CustomerType.ViewModels;

namespace FSSCM.Web.Pages.Customers.CustomerType
{
    public class CreateModalModel : FSSCMPageModel
    {
        [BindProperty]
        public CreateEditCustomerTypeViewModel ViewModel { get; set; }

        private readonly ICustomerTypeAppService _service;

        public CreateModalModel(ICustomerTypeAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerTypeViewModel, CreateUpdateCustomerTypeDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}