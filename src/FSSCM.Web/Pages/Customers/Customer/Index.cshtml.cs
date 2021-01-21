using System.Threading.Tasks;

namespace FSSCM.Web.Pages.Customers.Customer
{
    public class IndexModel : FSSCMPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
