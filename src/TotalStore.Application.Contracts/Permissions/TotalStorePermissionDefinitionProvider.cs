using TotalStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace TotalStore.Permissions;

public class TotalStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //var myGroup = context.AddGroup(TotalStorePermissions.GroupName);


        var totalStoreGroup = context.AddGroup(TotalStorePermissions.GroupName);

        totalStoreGroup.AddPermission(TotalStorePermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        totalStoreGroup.AddPermission(TotalStorePermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        var productsPermission = totalStoreGroup.AddPermission(TotalStorePermissions.Products.Default, L("Permission:Products"));
        productsPermission.AddChild(TotalStorePermissions.Products.Create, L("Permission:Products.Create"));
        productsPermission.AddChild(TotalStorePermissions.Products.Edit, L("Permission:Products.Edit"));
        productsPermission.AddChild(TotalStorePermissions.Products.Delete, L("Permission:Products.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TotalStoreResource>(name);
    }
}
