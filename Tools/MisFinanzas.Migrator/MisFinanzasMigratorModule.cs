using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MisFinanzas.EntityFramework;

namespace MisFinanzas.Migrator
{
    [DependsOn(typeof(MisFinanzasDataModule))]
    public class MisFinanzasMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MisFinanzasDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}