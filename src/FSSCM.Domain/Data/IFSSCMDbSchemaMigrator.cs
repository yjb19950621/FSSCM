using System.Threading.Tasks;

namespace FSSCM.Data
{
    public interface IFSSCMDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
