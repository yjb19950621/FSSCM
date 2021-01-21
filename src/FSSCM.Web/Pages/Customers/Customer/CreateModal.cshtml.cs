using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Customers;
using FSSCM.Customers.Dtos;
using FSSCM.Web.Pages.Customers.Customer.ViewModels;

namespace FSSCM.Web.Pages.Customers.Customer
{
    public class CreateModalModel : FSSCMPageModel
    {
        [BindProperty]
        public CreateEditCustomerViewModel ViewModel { get; set; }

        private readonly ICustomerAppService _service;

        public CreateModalModel(ICustomerAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerViewModel, CreateUpdateCustomerDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}