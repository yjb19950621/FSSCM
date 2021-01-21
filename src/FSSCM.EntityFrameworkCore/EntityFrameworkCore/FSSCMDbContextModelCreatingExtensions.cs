using FSSCM.Customers;
using FSSCM.Product;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace FSSCM.EntityFrameworkCore
{
    public static class FSSCMDbContextModelCreatingExtensions
    {
        public static void ConfigureFSSCM(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FSSCMConsts.DbTablePrefix + "YourEntities", FSSCMConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<GoodsType>(b =>
            {
                b.ToTable(FSSCMConsts.DbTablePrefix + "GoodsTypes", FSSCMConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<GoodsUnit>(b =>
            {
                b.ToTable(FSSCMConsts.DbTablePrefix + "GoodsUnits", FSSCMConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Customer>(b =>
            {
                b.ToTable(FSSCMConsts.DbTablePrefix + "Customers", FSSCMConsts.DbSchema);
                b.Property(p => p.Id)
                            .HasColumnName("CustomerID");
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<CustomerType>(b =>
            {
                b.ToTable(FSSCMConsts.DbTablePrefix + "CustomerTypes", FSSCMConsts.DbSchema);
                b.Property(p => p.Id)
                            .HasColumnName("CustomerTypeID");
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<CustomerTagBTOs>(b =>
            {
                b.ToTable(FSSCMConsts.DbTablePrefix + "CustomerTagBTOs", FSSCMConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
