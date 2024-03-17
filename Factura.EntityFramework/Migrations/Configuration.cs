using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using FacturaApp.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace FacturaApp.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<FacturaApp.EntityFramework.FacturaAppDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FacturaApp";
        }

        protected override void Seed(FacturaApp.EntityFramework.FacturaAppDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
