using System.Threading.Tasks;

namespace FSSCM.Web.Pages.Customer.Customer
{
    public class IndexModel : FSSCMPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
