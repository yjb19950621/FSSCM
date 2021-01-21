namespace FSSCM.Permissions
{
    public static class FSSCMPermissions
    {
        public const string GroupName = "FSSCM";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class GoodsUnit
        {
            public const string Default = GroupName + ".GoodsUnit";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class GoodsType
        {
            public const string Default = GroupName + ".GoodsType";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Customer
        {
            public const string Default = GroupName + ".Customer";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class CustomerType
        {
            public const string Default = GroupName + ".CustomerType";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class CustomerTagBTOs
        {
            public const string Default = GroupName + ".CustomerTagBTOs";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
