using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Customers;
using FSSCM.Customers.Dtos;
using FSSCM.Web.Pages.Customers.Customer.ViewModels;

namespace FSSCM.Web.Pages.Customers.Customer
{
    public class EditModalModel : FSSCMPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditCustomerViewModel ViewModel { get; set; }

        private readonly ICustomerAppService _service;

        public EditModalModel(ICustomerAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<CustomerDto, CreateEditCustomerViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerViewModel, CreateUpdateCustomerDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}