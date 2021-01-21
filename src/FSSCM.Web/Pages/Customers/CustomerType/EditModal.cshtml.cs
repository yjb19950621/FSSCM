using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSSCM.Customers;
using FSSCM.Customers.Dtos;
using FSSCM.Web.Pages.Customers.CustomerType.ViewModels;

namespace FSSCM.Web.Pages.Customers.CustomerType
{
    public class EditModalModel : FSSCMPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditCustomerTypeViewModel ViewModel { get; set; }

        private readonly ICustomerTypeAppService _service;

        public EditModalModel(ICustomerTypeAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<CustomerTypeDto, CreateEditCustomerTypeViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerTypeViewModel, CreateUpdateCustomerTypeDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}