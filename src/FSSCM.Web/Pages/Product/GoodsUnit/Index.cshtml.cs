using System.Threading.Tasks;

namespace FSSCM.Web.Pages.Product.GoodsUnit
{
    public class IndexModel : FSSCMPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
