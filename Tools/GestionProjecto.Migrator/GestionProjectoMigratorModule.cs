using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using FacturaApp.EntityFramework;

namespace FacturaApp.Migrator
{
    [DependsOn(typeof(FacturaAppDataModule))]
    public class FacturaAppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<FacturaAppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}