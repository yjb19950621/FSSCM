using FSSCM.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FSSCM.Permissions
{
    public class FSSCMPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FSSCMPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FSSCMPermissions.MyPermission1, L("Permission:MyPermission1"));

            var goodsUnitPermission = myGroup.AddPermission(FSSCMPermissions.GoodsUnit.Default, L("Permission:GoodsUnit"));
            goodsUnitPermission.AddChild(FSSCMPermissions.GoodsUnit.Create, L("Permission:Create"));
            goodsUnitPermission.AddChild(FSSCMPermissions.GoodsUnit.Update, L("Permission:Update"));
            goodsUnitPermission.AddChild(FSSCMPermissions.GoodsUnit.Delete, L("Permission:Delete"));

            var goodsTypePermission = myGroup.AddPermission(FSSCMPermissions.GoodsType.Default, L("Permission:GoodsType"));
            goodsTypePermission.AddChild(FSSCMPermissions.GoodsType.Create, L("Permission:Create"));
            goodsTypePermission.AddChild(FSSCMPermissions.GoodsType.Update, L("Permission:Update"));
            goodsTypePermission.AddChild(FSSCMPermissions.GoodsType.Delete, L("Permission:Delete"));

            var customerPermission = myGroup.AddPermission(FSSCMPermissions.Customer.Default, L("Permission:Customer"));
            customerPermission.AddChild(FSSCMPermissions.Customer.Create, L("Permission:Create"));
            customerPermission.AddChild(FSSCMPermissions.Customer.Update, L("Permission:Update"));
            customerPermission.AddChild(FSSCMPermissions.Customer.Delete, L("Permission:Delete"));

            var customerTypePermission = myGroup.AddPermission(FSSCMPermissions.CustomerType.Default, L("Permission:CustomerType"));
            customerTypePermission.AddChild(FSSCMPermissions.CustomerType.Create, L("Permission:Create"));
            customerTypePermission.AddChild(FSSCMPermissions.CustomerType.Update, L("Permission:Update"));
            customerTypePermission.AddChild(FSSCMPermissions.CustomerType.Delete, L("Permission:Delete"));

            var customerTagBTOsPermission = myGroup.AddPermission(FSSCMPermissions.CustomerTagBTOs.Default, L("Permission:CustomerTagBTOs"));
            customerTagBTOsPermission.AddChild(FSSCMPermissions.CustomerTagBTOs.Create, L("Permission:Create"));
            customerTagBTOsPermission.AddChild(FSSCMPermissions.CustomerTagBTOs.Update, L("Permission:Update"));
            customerTagBTOsPermission.AddChild(FSSCMPermissions.CustomerTagBTOs.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FSSCMResource>(name);
        }
    }
}
