using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Customers;
using FSSCM.Customers.Dtos;
using FSSCM.Web.Pages.Customers.CustomerTagBTOs.ViewModels;

namespace FSSCM.Web.Pages.Customers.CustomerTagBTOs
{
    public class EditModalModel : FSSCMPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public CreateEditCustomerTagBTOsViewModel ViewModel { get; set; }

        private readonly ICustomerTagBTOsAppService _service;

        public EditModalModel(ICustomerTagBTOsAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<CustomerTagBTOsDto, CreateEditCustomerTagBTOsViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerTagBTOsViewModel, CreateUpdateCustomerTagBTOsDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}