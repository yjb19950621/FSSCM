using Volo.Abp.Settings;

namespace FSSCM.Settings
{
    public class FSSCMSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FSSCMSettings.MySetting1));
        }
    }
}
