using System.Threading.Tasks;

namespace FSSCM.Web.Pages.Product.GoodsType
{
    public class IndexModel : FSSCMPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
