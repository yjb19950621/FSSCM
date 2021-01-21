using System.Threading.Tasks;

namespace FSSCM.Web.Pages.Customers.CustomerTagBTOs
{
    public class IndexModel : FSSCMPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
