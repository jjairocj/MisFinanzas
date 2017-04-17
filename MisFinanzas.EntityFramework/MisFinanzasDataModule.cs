using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MisFinanzas.EntityFramework;

namespace MisFinanzas
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MisFinanzasCoreModule))]
    public class MisFinanzasDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MisFinanzasDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
