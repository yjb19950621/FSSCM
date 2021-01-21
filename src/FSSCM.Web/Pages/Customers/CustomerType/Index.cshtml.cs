using System.Threading.Tasks;

namespace FSSCM.Web.Pages.Customers.CustomerType
{
    public class IndexModel : FSSCMPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
